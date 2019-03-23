using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    public class AbonementConfig : EntityTypeConfiguration<Abonement>
    {
        public AbonementConfig()
        {
            this.ToTable("tbl_abonements").HasKey(abon => abon.ClientId);
            this.Property(abon => abon.ClientId).HasColumnName("cln_abonement_clientId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(abon => abon.Price).HasColumnName("cln_abonement_price").IsRequired();
            this.Property(abon => abon.PurchaseDate).HasColumnName("cln_abonement_purchaseDate").IsRequired();
            this.Property(abon => abon.Status).HasColumnName("cln_abonement_status").IsRequired();

            this.HasRequired(abon => abon.Client)
                .WithRequiredPrincipal(c => c.Abonement);

            this.HasRequired(abon => abon.AbonementType)
                .WithRequiredDependent(t => t.Abonement);
        }
    }
}
