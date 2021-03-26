using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhehraReasturant.Models
{
    public class Order
    {
        public int ID { get; set; }//primary key
        public int CustomerID { get; set; }//customer id
        public Customercs Customercs { get; set; }//add relation of customer table


        public int MenuID { get; set; }//add menu id
        public Menu Menu { get; set; }//add relation of menu table

        public DateTime OrderDate { get; set; }//add order datek
    }
}
