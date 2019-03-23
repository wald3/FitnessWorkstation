using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace DbFitness.Configurations
{
    class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig()
        {
            this.ToTable("tbl_abonements").HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("cln_client_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.IsActive).HasColumnName("cln_client_isActive").IsRequired();

            this.HasRequired<Club>(s => s.Club)
                .WithMany(g => g.Clients)
                .HasForeignKey<int?>(s => s.ClubId);

            this.HasRequired<PersonInfo>(c => c.Bio)
                .WithRequiredDependent(pi => pi.Client);

            this.HasRequired<Abonement>(c => c.Abonement)
                .WithRequiredDependent(a => a.Client);
        }
    }
}
