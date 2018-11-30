using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class Category
    {
        public int CatID { get; set; } //pk
        public string CatName { get; set; }
        public List<Products> plist { get; set; }
    }
}
