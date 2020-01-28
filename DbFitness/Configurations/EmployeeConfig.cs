using DbFitness.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class EmployeeConfig : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfig()
        {
            this.HasKey(c => c.Id);

            this.HasRequired<Club>(p => p.Club)
                .WithMany(c => c.Employees)
                .HasForeignKey<int?>(p => p.ClubId)
                .WillCascadeOnDelete(false);

            this.HasOptional(pi => pi.Phone);
                //.WithRequired(p => (Employee)p.PhoneUser);

            this.HasRequired(pi => pi.Address);

            this.ToTable("employees", ".dbo");
            this.Property(c => c.Id).HasColumnName("employee_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.FirstName).HasColumnName("employee_first_name").HasMaxLength(30).IsRequired();
            this.Property(c => c.SecondName).HasColumnName("employee_second_name").HasMaxLength(30).IsRequired();
            this.Property(c => c.Age).HasColumnName("employee_age").IsRequired();
            this.Property(c => c.Salary).HasColumnName("employee_salary").IsRequired();
            this.Property(c => c.Position).HasColumnName("employee_position").IsRequired();
            this.Property(c => c.LastPayoutDate).HasColumnName("employee_last_poyout_date_utc").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            this.Property(c => c.EnrollmentDate).HasColumnName("employee_enrollment_date_utc").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            this.Property(c => c.ClubId).HasColumnName("employee_clud_id").IsRequired();
        }
    }
}
