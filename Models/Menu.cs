using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhehraReasturant.Models
{
    public class Menu
    {
        public int ID { get; set; }//primary key

        public string DishName { get; set; }//name of dish
        public string DitearyRestrictions { get; set; }//ditearyrestrictions
        public int Price { get; set; }//price of menu
        public int Rating { get; set; }//rating of menu
        public ICollection<Order> Orders { get; set; }//add relation
    }
}
