using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class PersonInfo : Table
    {
        public string FirstName  { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual Address Address { get; set; }

        public int? PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
