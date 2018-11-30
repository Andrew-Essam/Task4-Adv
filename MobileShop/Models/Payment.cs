using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class Payment
    {
        public int CardNo { get; set; } //pk
        public DateTime Exp_date { get; set; }
       public Orders _orders { get; set; }
    }
}
