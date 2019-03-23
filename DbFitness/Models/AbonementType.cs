using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class AbonementType
    {
        [Key]
        public int AbonementId { get; set; }
        public Types Type { get; set; }

        public Abonement Abonement { get; set; }
        
    }

     public enum Types
    {
         Year    = 365,
         MonthSix = 365 / 2,
         MonthThree = 365 / 4,
         MonthOne = 365 / 12,
         VisitNine = 9,
         Visit_3 = 3,
         Visit_1 = 1
     }
}
