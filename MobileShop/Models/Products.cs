using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class Products
    {
        
            public int PID { get; set; } // primary key
            public string PName { get; set; }
            public decimal Price { get; set; }
            public decimal Stock { get; set; }
           public List<Feedback> flist { get; set; }
        public int CatID { get; set; } //fk
         public Category _category { get; set; }
        public Suppliers _suppliers { get; set; }
        public List<OrderDetails> odlist { get; set; }
        //public int PID { get; set; } //fk
        public int oID { get; set; } //fk
        //el etnen el fo2 dol composite key 
    }
}
