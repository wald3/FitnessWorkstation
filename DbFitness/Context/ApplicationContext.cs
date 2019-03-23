using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DbFitness.Configurations;
using DbFitness.Models;

namespace DbFitness
{
    public class DbFitnessСontext : DbContext
    {
        public DbSet<Abonement> Abonements { get; set; }
        public DbSet<AbonementType> AbonementTypes { get; set; }
        public DbSet<Adress> Adreses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Employee> Empolyes { get; set; }
        public DbSet<EquipmentInfo> EquipmentInfo { get; set; }
        public DbSet<PersonInfo> PersonInfo { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<SportEquipment> SportEquipments { get; set; }

        public DbFitnessСontext() : base("DefaultConnection")
        { }

        protected override void OnModelCreating(DbModelBuilder optionsBuilder)
        {
            optionsBuilder.Configurations.Add(new AbonementConfig());
            optionsBuilder.Configurations.Add(new AbonementTypeConfig());
            optionsBuilder.Configurations.Add(new AdressConfig());
            optionsBuilder.Configurations.Add(new ClientConfig());
            optionsBuilder.Configurations.Add(new ClubConfig());
            optionsBuilder.Configurations.Add(new EmployeeConfig());
            optionsBuilder.Configurations.Add(new EquipmentInfoConfig());
            optionsBuilder.Configurations.Add(new PersonInfoConfig());
            optionsBuilder.Configurations.Add(new PhoneConfig());
            optionsBuilder.Configurations.Add(new PositionConfig());
            optionsBuilder.Configurations.Add(new SportEquipmentConfig());
        }
    }
}
