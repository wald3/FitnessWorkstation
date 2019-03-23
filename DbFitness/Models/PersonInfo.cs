using System.ComponentModel.DataAnnotations;

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
    }
}
