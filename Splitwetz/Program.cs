using CsvHelper;
using RestSharp;
using Splitwetz.Models;
using Splitwetz.Splitwise.Models;
using System.Globalization;
using System.Runtime.CompilerServices;

var SplitwiseKey = "lDH64rJ4poYbDz1fbEGanBjnw7vHT2o5ylT3MsP9";

var despesas = await readCsv();
var groups = await getGroups();
var expensesToCreate = await createSplitwiseRequest(despesas, groups);

foreach (var item in expensesToCreate)
{
    await createExpenses(item);
}


async Task<List<CreateExpenseRequest.Rootobject>> createSplitwiseRequest(List<ImportacaoDespesas> despesas, Splitwetz.Splitwise.Models.GetGroups.Rootobject groups)
{
    List<CreateExpenseRequest.Rootobject> ret = new List<CreateExpenseRequest.Rootobject>();

    despesas.ForEach(f =>
    {
        ret.Add(new CreateExpenseRequest.Rootobject()
        {
            cost = f.Valor.ToString().Replace(",","."),
            currency_code = "BRL",
            date = f.Data.ToString("yyyy-MM-ddTHH:mm:ss"),
            description = f.Nome,
            group_id = string.IsNullOrEmpty(f.Nome) ? 0 : groups.groups.Where(g => g.name == f.Grupo).FirstOrDefault().id,
            repeat_interval = "never",
            split_equally = true
        });
    });

    return ret;
}

async Task<List<ImportacaoDespesas>> readCsv()
{
    var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture);
    config.Delimiter = ";";
    config.HasHeaderRecord = true;

    using (var reader = new StreamReader("gastos.csv"))
    using (var csv = new CsvReader(reader, config))
    {
        var ret = csv.GetRecords<ImportacaoDespesas>().ToList();
        return ret;
    }
}

async Task createExpenses(CreateExpenseRequest.Rootobject expense)
{
    var request = new RestRequest("https://secure.splitwise.com/api/v3.0/create_expense");
    request.AddHeader("Authorization", $"Bearer {SplitwiseKey}");
    request.AddJsonBody(Newtonsoft.Json.JsonConvert.SerializeObject(expense), false);

    RestSharp.RestClient client = new RestSharp.RestClient();
    var ret = await client.PostAsync(request);
}

async Task<Splitwetz.Splitwise.Models.GetGroups.Rootobject> getGroups()
{
    var request = new RestRequest("https://secure.splitwise.com/api/v3.0/get_groups");
    request.AddHeader("Authorization", $"Bearer {SplitwiseKey}");

    RestSharp.RestClient client = new RestSharp.RestClient();
    var groups = await client.GetAsync<Splitwetz.Splitwise.Models.GetGroups.Rootobject>(request);

    return groups;
}