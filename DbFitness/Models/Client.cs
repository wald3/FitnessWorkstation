using System.ComponentModel.DataAnnotations;

namespace DbFitness.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public PersonInfo Bio { get; set; }
        public Abonement Abonement { get; set; }

        // One-To-Many relation
        public int ClubId { get; set; }
        public Club Club { get; set; }
    }
}
