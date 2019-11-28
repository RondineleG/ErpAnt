using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpAnt.ApplicationCore.Models
{
    [ Table ( "Customer" )]
    public class Customer : ModelBase
    {
        public Customer()
        {
            CreatedDate = DateTime.Now;
        }

        [Required(ErrorMessage = "The Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }

        public string Phone { get; set; }         


        [Required(ErrorMessage = "Email is required")]
        [StringLength(100, ErrorMessage = "Email can't be longer than 50 characters")]
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        /* EF Relations */
        public ICollection<Order> Orders { get; set; }

         
    }
}
  