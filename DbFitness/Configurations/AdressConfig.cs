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
    class AdressConfig : EntityTypeConfiguration<Adress>
    {
        public AdressConfig()
        {  
            this.ToTable("tbl_adress").HasKey(a => a.Id);
            this.Property(a => a.Id).HasColumnName("cln_adress_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Country).HasColumnName("cln_adress_country").HasMaxLength(100).IsRequired();
            this.Property(a => a.City).HasColumnName("cln_adress_city").HasMaxLength(100).IsRequired();
            this.Property(a => a.Street).HasColumnName("cln_adress_street").HasMaxLength(100).IsRequired();
            this.Property(a => a.BuildingNumber).HasColumnName("cln_adress_buildingNumber").IsRequired();
            this.Property(a => a.Housing).HasColumnName("cln_adress_housing").IsOptional();
        }
    }
}
