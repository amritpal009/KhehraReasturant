using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhehraReasturant.Models
{
    public class Customercs
    {
        public int ID { get; set; }//primary key
        public string FirstName { get; set; }//first name of customer
        public string Surname { get; set; }//surname name of customer

        public int Phone { get; set; }//phone of customer
        public string Address { get; set; }//address of customer
        public ICollection<Order> Orders { get; set; }//add icollection
    }
}
