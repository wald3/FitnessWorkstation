using System.Data.Entity;
using DbFitness.Configurations;
using DbFitness.Models;
using DbFitness.Initializer;
using System.Configuration;

namespace DbFitness.Context
{
    public class DbFitnessСontext : DbContext
    {
        public DbFitnessСontext() : base(ConfigurationManager.ConnectionStrings["ConnectionStringKey"].ConnectionString)
        { }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Client> Cients { get; set; }
        public DbSet<Abonement> Abonements { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }
        public DbSet<SportEquipment> SportEquipments { get; set; }
        public DbSet<EquipmentInfo> EquipmentInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder optionsBuilder)
        {
            optionsBuilder.Configurations.Add(new ClubConfig());
            optionsBuilder.Configurations.Add(new EmployeeConfig());
            optionsBuilder.Configurations.Add(new ClientConfig());
            optionsBuilder.Configurations.Add(new AbonementConfig());
            optionsBuilder.Configurations.Add(new PhoneConfig());
            optionsBuilder.Configurations.Add(new AddressConfig());
            optionsBuilder.Configurations.Add(new UserInfoConfig());
            optionsBuilder.Configurations.Add(new SportEquipmentConfig());
            optionsBuilder.Configurations.Add(new EquipmentInfoConfig());
        }
    }
}
