using DbFitness.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig()
        {
            this.HasRequired<Club>(c => c.Club)
                .WithMany(c => c.Clients)
                .HasForeignKey<int?>(c => c.ClubId)
                .WillCascadeOnDelete(false);

            this.HasOptional(c => c.Phone);                

            this.HasRequired(c => c.Address);

            this.HasOptional(c => c.Abonement);

            this.ToTable("clients", ".dbo");
            this.Property(c => c.Id).HasColumnName("client_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.FirstName).HasColumnName("client_first_name").HasMaxLength(30).IsRequired();
            this.Property(c => c.SecondName).HasColumnName("client_second_name").HasMaxLength(30).IsRequired();
            this.Property(c => c.Age).HasColumnName("client_age").IsRequired();
            this.Property(c => c.RegistrationDate).HasColumnName("client_registration_date_utc").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            this.Property(c => c.ClubId).HasColumnName("client_clud_id").IsRequired();
        }
    }
}