using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Address : Table
    {
        public string Country { get; set; }
        public string StreetName { get; set; }
        public int Housing { get; set; }
    }
}
