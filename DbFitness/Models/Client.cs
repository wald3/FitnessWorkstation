using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }

        public int ClubId { get; set; }
        public Club Club { get; set; }

        public virtual PersonInfo Bio { get; set; }
        public virtual Abonement Abonement { get; set; }
    }
}
