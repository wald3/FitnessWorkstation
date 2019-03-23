using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class PhoneConfig : EntityTypeConfiguration<Phone>
    {
        public PhoneConfig()
        {
            this.ToTable("tbl_phones").HasKey(p => p.Id);
            this.Property(p => p.Id).HasColumnName("cln_phone_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.PhoneOperator).HasColumnName("cln_phone_phoneOperator").HasMaxLength(50);
            this.Property(p => p.CountryCode).HasColumnName("cln_phone_countryCode");
            this.Property(p => p.PhoneCode).HasColumnName("cln_phone_phoneCode");
            this.Property(p => p.PhoneNumber).HasColumnName("cln_phone_phoneNumber");
        }
    }
}
