using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class ClubConfig : EntityTypeConfiguration<Club>
    {
        public ClubConfig()
        {
            this.HasMany<Client> (c => c.Clients)
                .WithRequired(c => c.Club)
                .HasForeignKey(c => c.ClubId);

            this.HasMany<Employee>(c => c.Employees)
                .WithRequired(e => e.Club)
                .HasForeignKey(e => e.ClubId);

            this.HasMany<SportEquipment>(c => c.SportEquipments)
                .WithRequired(e => e.Club)
                .HasForeignKey(e => e.ClubId);

            this.HasOptional(c => c.Address);

            this.ToTable("club");
            this.Property(c => c.Id).HasColumnName("club_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Name).HasColumnName("club_name").HasMaxLength(50).IsRequired();
        }
    }
}