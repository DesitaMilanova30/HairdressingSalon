﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Models.Client
{
    public class CreateClientVM
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

    }
}
