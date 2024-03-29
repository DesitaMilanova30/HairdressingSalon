﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Entities
{
    public class Hairdresser
    {
        public Hairdresser()
        {
            this.Reports = new HashSet<Report>();
            this.Reports = new HashSet<Report>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Hour> Hours { get; set; }
        public virtual ICollection<Report> Reports { get; set; }

    }
}
