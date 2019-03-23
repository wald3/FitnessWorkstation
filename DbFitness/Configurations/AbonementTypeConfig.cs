using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class AbonementTypeConfig : EntityTypeConfiguration<AbonementType>
    {
        public AbonementTypeConfig()
        {
            this.ToTable("tbl_abonementsTypes").HasKey(at => at.AbonementId);
            this.Property(at => at.AbonementId).HasColumnName("cln_abonementType_abonementId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(at => at.Type).HasColumnName("cln_abonementType_type").IsRequired();
        }
    }
}
