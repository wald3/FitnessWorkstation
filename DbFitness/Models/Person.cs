using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Person : Table
    {
        public PersonInfo PersonInfo { get; set; }
        public int? ClubId { get; set; }
        public virtual Club Club { get; set; }
    }
}
