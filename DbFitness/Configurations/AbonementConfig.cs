using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class AbonementConfig : EntityTypeConfiguration<Abonement>
    {
        public AbonementConfig()
        {
            this.ToTable("abonement");
            this.Property(c => c.Id).HasColumnName("abonement_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.isActive).HasColumnName("abonement_is_active").IsRequired();
            this.Property(c => c.Price).HasColumnName("abonement_price").IsRequired();
            this.Property(c => c.PurchaseDate).HasColumnName("abonement_purchase_date_utc").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            this.Property(c => c.Type).HasColumnName("abonement_type").IsRequired();
        }
    }
}