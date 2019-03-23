using DbFitness.Models;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class PersonInfoConfig : EntityTypeConfiguration<PersonInfo>
    {
        public PersonInfoConfig()
        {
            this.ToTable("tbl_personeInfos").HasKey(pi => pi.Id);
            this.Property(pi => pi.FisrtName).HasColumnName("cln_personInfo_firstName");
            this.Property(pi => pi.SecondName).HasColumnName("cln_personInfo_secondName");
            this.Property(pi => pi.Age).HasColumnName("cln_personInfo_age");
        }
    }
}
