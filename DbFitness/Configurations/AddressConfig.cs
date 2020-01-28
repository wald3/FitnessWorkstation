using DbFitness.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class AddressConfig : EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            this.ToTable("address");
            this.Property(c => c.Id).HasColumnName("address_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Country).HasColumnName("address_country").HasMaxLength(50).IsRequired();
            this.Property(c => c.StreetName).HasColumnName("address_street_name").HasMaxLength(30).IsRequired();
            this.Property(c => c.Housing).HasColumnName("address_house_number").IsRequired();
        }
    }
}
