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

            this.HasOptional(c => c.Abonement);

            this.ToTable("clients");
            this.Property(c => c.Id).HasColumnName("client_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.RegistrationDate).HasColumnName("client_registration_date_utc").IsRequired();
            this.Property(c => c.ClubId).HasColumnName("client_clud_id").IsRequired();
        }
    }
}