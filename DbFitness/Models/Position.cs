using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public Positions CurrentPosition { get; set; }

        public virtual Empolyee Empolyee {get; set; }
    }

    public enum Positions
    {    
        Administrator = 1,
        TrainerO = 4,
        TrainerE = 3,
        Cleaner = 3
        
    }
}
