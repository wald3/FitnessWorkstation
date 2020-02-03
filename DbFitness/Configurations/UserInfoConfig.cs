using DbFitness.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class UserInfoConfig : EntityTypeConfiguration<UserInfo>
    {
        public UserInfoConfig()
        {
            this.ToTable("user_info");
            this.Property(c => c.Id).HasColumnName("user_info_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.FirstName).HasColumnName("user_first_name").HasMaxLength(30).IsRequired();
            this.Property(c => c.SecondName).HasColumnName("user_second_name").HasMaxLength(30).IsRequired();
            this.Property(c => c.Age).HasColumnName("user_age").IsRequired();
        }
    }
}
