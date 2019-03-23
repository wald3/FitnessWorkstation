using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig()
        {
            this.ToTable("tbl_clients").HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("cln_client_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.IsActive).HasColumnName("cln_client_isActive").IsRequired();
            this.Property(c => c.ClubId).HasColumnName("cln_client_clubId").IsRequired();
        }
    }
}
