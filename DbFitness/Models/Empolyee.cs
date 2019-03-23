using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DbFitness.Models
{
    public class Empolyee
    {
        [Key]
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime LastPayoutDate { get; set; }
        public DateTime LastVacationDate { get; set; }

        public virtual PersonInfo Bio { get; set; }
        public virtual Position Position { get; set; }
    }
}
