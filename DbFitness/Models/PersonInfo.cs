using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class PersonInfo
    {
        [Key]
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public Adress Adress { get; set; }
        public Phone Phone { get; set; }

        public Client Client { get; set; }
    }
}
