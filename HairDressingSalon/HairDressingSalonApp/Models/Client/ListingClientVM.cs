using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Models.Client
{
    public class ListingClientVM
    {
        [Key]
        public int Id { get; set; }
   
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
      
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public DateTime Birthday { get; set; }
    }
}
