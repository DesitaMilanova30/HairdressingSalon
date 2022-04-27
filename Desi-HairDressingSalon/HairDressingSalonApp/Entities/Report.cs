using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Entities
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client  { get; set; }

        public int HairdresserId { get; set; }
        public virtual Hairdresser Hairdresser { get; set; }
        public int Price { get; set; }
                
        public int Start { get; set; }
        public string Description { get; set;  }
    }
}


