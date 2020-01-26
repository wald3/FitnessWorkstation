using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Club : Table
    {
        public string ClubName { get; set; }
        public virtual Address Address { get; set; }
        public ICollection<Person> Persons { get; set; }

        public Club()
        {
            Persons = new List<Person>();
        }
    }
}
