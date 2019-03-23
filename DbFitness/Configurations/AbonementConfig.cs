using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    public class AbonementConfig : EntityTypeConfiguration<Abonement>
    {
        public AbonementConfig()
        {
            this.ToTable("tbl_abonements").HasKey(a => a.ClientId);
            this.Property(a => a.ClientId).HasColumnName("cln_abonement_clientId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Price).HasColumnName("cln_abonement_price").IsRequired();
            this.Property(a => a.PurchaseDate).HasColumnName("cln_abonement_purchaseDate").IsRequired();
            this.Property(a => a.Status).HasColumnName("cln_abonement_status").IsRequired();
        }
    }
}
