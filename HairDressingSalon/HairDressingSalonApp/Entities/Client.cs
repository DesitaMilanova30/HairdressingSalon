using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public virtual string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
