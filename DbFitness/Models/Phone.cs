using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Phone : Table
    {
        public int CountryCode  { get; set; }
        public int OperatorCode { get; set; }
        public int PhoneNumber  { get; set; }
    }
}
