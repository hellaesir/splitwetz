using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitwetz.Splitwise.Models
{
    public class CreateExpenseRequest
    {
        public class Rootobject
        {
            public string cost { get; set; }
            public string description { get; set; }
            public string date { get; set; }
            public string repeat_interval { get; set; }
            public string currency_code { get; set; }
            public int group_id { get; set; }
            public bool split_equally { get; set; }
        }
    }

    public class CreateExpenseResponse
    {
        public class Expens
        {
            public string cost { get; set; }
            public string description { get; set; }
            public string details { get; set; }
            public DateTime date { get; set; }
            public string repeat_interval { get; set; }
            public string currency_code { get; set; }
            public int category_id { get; set; }
            public int id { get; set; }
            public int group_id { get; set; }
            public int friendship_id { get; set; }
            public int expense_bundle_id { get; set; }
            public bool repeats { get; set; }
            public bool email_reminder { get; set; }
            public object email_reminder_in_advance { get; set; }
            public string next_repeat { get; set; }
            public int comments_count { get; set; }
            public bool payment { get; set; }
            public bool transaction_confirmed { get; set; }
            public Repayment[] repayments { get; set; }
            public DateTime created_at { get; set; }
            public Created_By created_by { get; set; }
            public DateTime updated_at { get; set; }
            public Updated_By updated_by { get; set; }
            public DateTime deleted_at { get; set; }
            public Deleted_By deleted_by { get; set; }
            public Category category { get; set; }
            public Receipt receipt { get; set; }
            public User[] users { get; set; }
            public Comment[] comments { get; set; }
        }

        public class Created_By
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string registration_status { get; set; }
            public Picture picture { get; set; }
        }

        public class Picture
        {
            public string small { get; set; }
            public string medium { get; set; }
            public string large { get; set; }
        }

        public class Updated_By
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string registration_status { get; set; }
            public Picture1 picture { get; set; }
        }

        public class Picture1
        {
            public string small { get; set; }
            public string medium { get; set; }
            public string large { get; set; }
        }

        public class Deleted_By
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string registration_status { get; set; }
            public Picture2 picture { get; set; }
        }

        public class Picture2
        {
            public string small { get; set; }
            public string medium { get; set; }
            public string large { get; set; }
        }

        public class Category
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Receipt
        {
            public string large { get; set; }
            public string original { get; set; }
        }

        public class Repayment
        {
            public int from { get; set; }
            public int to { get; set; }
            public string amount { get; set; }
        }

        public class User
        {
            public User1 user { get; set; }
            public int user_id { get; set; }
            public string paid_share { get; set; }
            public string owed_share { get; set; }
            public string net_balance { get; set; }
        }

        public class User1
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public Picture3 picture { get; set; }
        }

        public class Picture3
        {
            public string medium { get; set; }
        }

        public class Comment
        {
            public int id { get; set; }
            public string content { get; set; }
            public string comment_type { get; set; }
            public string relation_type { get; set; }
            public int relation_id { get; set; }
            public DateTime created_at { get; set; }
            public DateTime deleted_at { get; set; }
            public User2 user { get; set; }
        }

        public class User2
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public Picture4 picture { get; set; }
        }

        public class Picture4
        {
            public string medium { get; set; }
        }

    }
}
