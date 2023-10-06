using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitwetz.Splitwise.Models.GetGroups
{

    public class Rootobject
    {
        public List<Group> groups { get; set; }
    }

    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public List<Member> members { get; set; }
        public bool simplify_by_default { get; set; }
        public List<Original_Debts> original_debts { get; set; }
        public List<Simplified_Debts> simplified_debts { get; set; }
        public Avatar avatar { get; set; }
        public Tall_Avatar tall_avatar { get; set; }
        public bool custom_avatar { get; set; }
        public Cover_Photo cover_photo { get; set; }
        public object whiteboard { get; set; }
        public string group_type { get; set; }
        public string invite_link { get; set; }
        public object group_reminders { get; set; }
    }

    public class Avatar
    {
        public string small { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
        public string xlarge { get; set; }
        public string xxlarge { get; set; }
        public string original { get; set; }
    }

    public class Tall_Avatar
    {
        public string xlarge { get; set; }
        public string large { get; set; }
    }

    public class Cover_Photo
    {
        public string xxlarge { get; set; }
        public string xlarge { get; set; }
    }

    public class Member
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Picture picture { get; set; }
        public bool custom_picture { get; set; }
        public string email { get; set; }
        public string registration_status { get; set; }
        public List<Balance> balance { get; set; }
    }

    public class Picture
    {
        public string small { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
    }

    public class Balance
    {
        public string amount { get; set; }
        public string currency_code { get; set; }
    }

    public class Original_Debts
    {
        public int from { get; set; }
        public int to { get; set; }
        public string amount { get; set; }
        public string currency_code { get; set; }
    }

    public class Simplified_Debts
    {
        public int from { get; set; }
        public int to { get; set; }
        public string amount { get; set; }
        public string currency_code { get; set; }
    }

    //    public class GetGroup
    //    {
    //        public class Rootobject
    //{
    //            public int id { get; set; }
    //            public string name { get; set; }
    //            public DateTime created_at { get; set; }
    //            public DateTime updated_at { get; set; }
    //            public List<Member> members { get; set; }
    //            public bool simplify_by_default { get; set; }
    //            public List<Original_Debts> original_debts { get; set; }
    //            public List<Simplified_Debts> simplified_debts { get; set; }
    //            public Avatar avatar { get; set; }
    //            public Tall_Avatar tall_avatar { get; set; }
    //            public bool custom_avatar { get; set; }
    //            public Cover_Photo cover_photo { get; set; }
    //            public object whiteboard { get; set; }
    //            public string group_type { get; set; }
    //            public string invite_link { get; set; }
    //            public object group_reminders { get; set; }
    //        }

    //        public class Avatar
    //        {
    //            public string small { get; set; }
    //            public string medium { get; set; }
    //            public string large { get; set; }
    //            public string xlarge { get; set; }
    //            public string xxlarge { get; set; }
    //            public string original { get; set; }
    //        }

    //        public class Tall_Avatar
    //        {
    //            public string xlarge { get; set; }
    //            public string large { get; set; }
    //        }

    //        public class Cover_Photo
    //        {
    //            public string xxlarge { get; set; }
    //            public string xlarge { get; set; }
    //        }

    //        public class Member
    //        {
    //            public int id { get; set; }
    //            public string first_name { get; set; }
    //            public string last_name { get; set; }
    //            public Picture picture { get; set; }
    //            public bool custom_picture { get; set; }
    //            public string email { get; set; }
    //            public string registration_status { get; set; }
    //            public List<Balance> balance { get; set; }
    //        }

    //        public class Picture
    //        {
    //            public string small { get; set; }
    //            public string medium { get; set; }
    //            public string large { get; set; }
    //        }

    //        public class Balance
    //        {
    //            public string amount { get; set; }
    //            public string currency_code { get; set; }
    //        }

    //        public class Original_Debts
    //        {
    //            public int from { get; set; }
    //            public int to { get; set; }
    //            public string amount { get; set; }
    //            public string currency_code { get; set; }
    //        }

    //        public class Simplified_Debts
    //        {
    //            public int from { get; set; }
    //            public int to { get; set; }
    //            public string amount { get; set; }
    //            public string currency_code { get; set; }
    //        }

    //    }
}