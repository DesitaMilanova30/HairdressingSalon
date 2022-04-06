using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Models.Hairdresser
{
    public class ListingHairdresserVM
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        
        [Display(Name = "LastName")]
        public string LastName { get; set; }


        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

    }
}
