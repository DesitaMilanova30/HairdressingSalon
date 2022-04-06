using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Entities
{
    public class Reservation
    {
        public int Id { get; set; }

        

        [Required]
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }


        [Required]
        public int HourId { get; set; }

        public virtual Hour Hour { get; set; }
        [MinLength(10)]
        [MaxLength(100)]
        public string Description { get; set; }


    }
}
