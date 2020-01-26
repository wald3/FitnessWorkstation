using System.Data.Entity;
using DbFitness.Configurations;
using DbFitness.Models;
using DbFitness.Initializer;


namespace DbFitness.Context
{
    public class DbFitnessСontext : DbContext
    {
        public DbFitnessСontext() : base("FitnessDb")
        {
            Database.SetInitializer<DbFitnessСontext>(new DbInitializer());
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonInfo> PersonInfos { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder optionsBuilder)
        {
            optionsBuilder.Configurations.Add(new ClubConfig());
            optionsBuilder.Configurations.Add(new PersonConfig());
            optionsBuilder.Configurations.Add(new PersonInfoConfig());
            optionsBuilder.Configurations.Add(new PhoneConfig());
        }
    }
}
