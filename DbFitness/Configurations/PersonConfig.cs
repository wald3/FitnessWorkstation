using DbFitness.Models;
using System.Data.Entity.ModelConfiguration;


namespace DbFitness.Configurations
{
    class PersonConfig : EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            this.HasRequired<Club>(p => p.Club)
                .WithMany(c => c.Persons)
                .HasForeignKey<int?>(p => p.ClubId);

            this.HasOptional(p => p.PersonInfo);
        }
    }
}
