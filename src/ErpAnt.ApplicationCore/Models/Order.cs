using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpAnt.ApplicationCore.Models
{  
    [ Table ( "Order" )]
    public class Order : ModelBase
    {
        public Guid CustomerId { get; set; }

       /* EF Relations */
        public Customer Customer { get; set; }

        public string Description { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "The Price is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
         public decimal Price { get; set; }
         public DateTime CreatedDate { get; set; }

       
    }
}