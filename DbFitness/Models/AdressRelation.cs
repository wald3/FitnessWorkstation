using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    class AdressRelation
    {
        [Key]
        public int AdressId { get; set; }
        public int InfoId { get; set; }
        public int ClubId { get; set; }
    }
}
