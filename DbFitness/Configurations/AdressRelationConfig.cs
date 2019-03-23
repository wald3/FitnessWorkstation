using DbFitness.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Configurations
{
    class AdressRelationConfig : EntityTypeConfiguration<AdressRelation>
    {
        public AdressRelationConfig()
        {
            this.ToTable("tbl_adressRelation").HasKey(a => a.AdressId);
            this.Property(a => a.AdressId).HasColumnName("cln_adress_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
