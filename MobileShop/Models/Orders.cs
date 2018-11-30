using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class Orders
    {
        public int oID { get; set; } //pk
        public DateTime Date { get; set; }
        public string DeliveryStatus{ get; set; }
        public List<Customers> clist { get; set; }
        public Feedback _feedback { get; set; }
        public List<OrderDetails> odlist { get; set; }
        public int CardNo { get; set; } //fk
        public Payment _payment { get; set; }

    }
}
