using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL
{
    class usersbll
    {
        public int id { get; set; }
        public string user_name { get; set; }
        public string user_type { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string cnic { get; set; }
        public string adress { get; set; }
        public string phone_no { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }

    }
}
