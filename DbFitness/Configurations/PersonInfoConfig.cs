using DbFitness.Models;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class PersonInfoConfig : EntityTypeConfiguration<PersonInfo>
    {
        public PersonInfoConfig()
        {
            this.HasRequired<Person>(pi => pi.Person)
                .WithOptional(p => p.PersonInfo)
                .WillCascadeOnDelete(false);

            this.HasOptional(pi => pi.Phone)
                .WithRequired(p => p.PersonInfo);

            this.HasRequired(pi => pi.Address);
            
        }
    }
}
