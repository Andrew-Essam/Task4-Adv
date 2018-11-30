using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class Customers
    {
        
        
            public int CID { get; set; } //primary key
            public string CName { get; set; }
            public string CPassword { get; set; }
            public int CAge { get; set; }
            public string CEmail { get; set; }
            public string CPhone { get; set; }
            public List<Orders> olist { get; set; }
        public List<Feedback> flist { get; set; }
        
    }
}
