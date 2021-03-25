using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhehraReasturant.Models
{
    public class Customercs
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public int Phone { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
