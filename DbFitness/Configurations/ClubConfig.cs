using DbFitness.Models;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class ClubConfig : EntityTypeConfiguration<Club>
    {
        public ClubConfig()
        {
            this.HasMany<Person>(s => s.Persons)
                .WithRequired(p => p.Club)
                .HasForeignKey(p => p.ClubId);

            this.HasOptional(c => c.Address);
        }
    }
}