using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Client : User
    {
        public DateTime RegistrationDate { get; set; }
        public Abonement Abonement { get; set; }
        public int? ClubId { get; set; }
        public virtual Club Club { get; set; }
    }
}
