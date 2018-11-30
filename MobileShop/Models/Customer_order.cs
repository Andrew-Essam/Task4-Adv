using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class Customer_order
    {
        //model for many to many relationshop
        public int CID { get; set; }
        public Customers _customer { get; set; }
        public int oID { get; set; }
        public Orders _orders { get; set; }
    }
}
