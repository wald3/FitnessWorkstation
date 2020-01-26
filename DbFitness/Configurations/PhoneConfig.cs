using DbFitness.Models;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class PhoneConfig : EntityTypeConfiguration<Phone>
    {
        public PhoneConfig()
        {
            this.HasRequired<PersonInfo>(p => p.PersonInfo);
        }
    }
}
