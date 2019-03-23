using System.ComponentModel.DataAnnotations;

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
