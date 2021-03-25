using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhehraReasturant.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public Customercs Customercs { get; set; }


        public int MenuID { get; set; }
        public Menu Menu { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
