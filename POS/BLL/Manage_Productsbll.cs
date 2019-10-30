using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL
{
    class Manage_Productsbll
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public string colour_code { get; set; }
        public string supplier { get; set; }
        public string catagory { get; set; }
        public string purchase_price { get; set; }
        public string retail_price { get; set; }
        public string type { get; set; }
        public string quantity { get; set; }
        public int added_by { get; set; }
        public DateTime added_date { get; set; }
        
    }
}
