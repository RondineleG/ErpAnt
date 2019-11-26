using System;

namespace ErpAnt.ApplicationCore.Models
{
    public class Order
    {
        public Guid CustomerId { get; set; }

       /* EF Relations */
        public Customer Customer { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
         public DateTime CreatedDate { get; set; }

       
    }
}