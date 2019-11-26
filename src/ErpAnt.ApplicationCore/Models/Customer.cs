using System.Collections.Generic;

namespace ErpAnt.ApplicationCore.Models
{
    public class Customer : ModelBase
    {
        public Customer()
        {
            
        }
        public string Name { get; set; }

        public string Phone { get; set; }         

        public string Email { get; set; }

        /* EF Relations */
        public IEnumerable<Order> Orders { get; set; }

         
    }
}