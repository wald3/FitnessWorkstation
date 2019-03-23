using System.ComponentModel.DataAnnotations;

namespace DbFitness.Models
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public string Housing { get; set; }
    }
}
