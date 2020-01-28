using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Club : Table
    {
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public Club()
        {
            Clients   = new List<Client>();
            Employees = new List<Employee>();
        }
    }
}
