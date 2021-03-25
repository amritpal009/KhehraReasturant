using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhehraReasturant.Models
{
    public class Menu
    {
        public int ID { get; set; }

        public string DishName { get; set; }
        public string DitearyRestrictions { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
