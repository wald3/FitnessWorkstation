using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Employee : Table
    {
        public int Salary { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? LastPayoutDate { get; set; }
        public Position Position { get; set; }
        public UserInfo UserInfo { get; set; }
        public int? ClubId { get; set; }
        public virtual Club Club { get; set; }
        public Employee()
        {
            EnrollmentDate = DateTime.UtcNow;
        }
    }
    public enum Position
    {
        Cleaner,
        Administrator,
        Trainer
    }
}
