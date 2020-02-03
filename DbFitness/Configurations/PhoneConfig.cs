using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class PhoneConfig : EntityTypeConfiguration<Phone>
    {
        public PhoneConfig()
        {
            //this.HasRequired<UserInfo>(p => p.PhoneUser);

            this.ToTable("phone");
            this.Property(c => c.Id).HasColumnName("phone_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.CountryCode).HasColumnName("phone_country_code").IsRequired();
            this.Property(c => c.OperatorCode).HasColumnName("phone_operator_code").IsRequired();
            this.Property(c => c.PhoneNumber).HasColumnName("phone_phone_number").IsRequired();
        }
    }
}