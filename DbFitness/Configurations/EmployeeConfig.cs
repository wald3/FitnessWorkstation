using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class EmployeeConfig : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfig()
        {
            this.ToTable("tbl_employees").HasKey(e => e.Id);
            this.Property(e => e.Id).HasColumnName("cln_employee_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.EnrollmentDate).HasColumnName("cln_employee_enrollmentDate");
            this.Property(e => e.LastPayoutDate).HasColumnName("cln_employee_lastPayOutDate");
            this.Property(e => e.LastVacationDate).HasColumnName("cln_employee_lastVacationDate");
        }
    }
}
