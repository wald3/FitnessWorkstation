using System;
using System.ComponentModel.DataAnnotations;

namespace DbFitness.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime LastPayoutDate { get; set; }
        public DateTime LastVacationDate { get; set; }
        public PersonInfo Bio { get; set; }
        public Position Position { get; set; }
    }
}
