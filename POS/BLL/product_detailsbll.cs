using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL
{
    class product_detailsbll
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string discount { get; set; }
        public string total { get; set; }
        public string purchase_price { get; set; }
        public string inv_no { get; set; }
        public string type { get; set; }
        public int added_by { get; set; }
        public DateTime added_date { get; set; }
        public int code { get; set; }
    }
}
