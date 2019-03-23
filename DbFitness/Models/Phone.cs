using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        public string PhoneOperator { get; set; }
        public int CountryCode { get; set; }
        public int PhoneCode { get; set; }
        public int PhoneNumber { get; set; }
    }
}
