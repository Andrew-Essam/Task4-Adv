using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class Feedback
    {
        //many to many relationship
        public int CID { get; set; }
        //FK
        public int PID { get; set; }
        //FK
        //EL ETNEN EL fo2 dol m3 b3d composite key (pk)=fk+fk
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public Customers _customers { get; set; }
        public List<Orders> olist { get; set; }
        public int oID { get; set; } //fk
        public List<Products> plist { get; set; }
    }
}
