using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFitness.Models;

namespace DbFitness.Configurations
{
    class AbonementTypeConfig : EntityTypeConfiguration<AbonementType>
    {
        public AbonementTypeConfig()
        {
            this.ToTable("tbl_abonementsTypes").HasKey(at => at.AbonementId);
            this.Property(at => at.AbonementId).HasColumnName("cln_abonementType_abonementId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(at => at.Type).HasColumnName("cln_abonementType").IsRequired();

            this.HasRequired(at => at.Abonement)
                .WithRequiredDependent(a => a.AbonementType);
        }
    }
}
