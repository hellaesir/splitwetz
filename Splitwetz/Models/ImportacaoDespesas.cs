using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitwetz.Models
{
    public class ImportacaoDespesas
    {
        public DateTime Data { get; set; }
        public string Grupo { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
