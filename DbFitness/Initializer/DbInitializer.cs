using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFitness.Context;
using DbFitness.Models;

namespace DbFitness.Initializer
{
    public class DbInitializer : DropCreateDatabaseAlways<DbFitnessСontext>
    {
        protected override void Seed(DbFitnessСontext db)
        {
            var clients = new List<Client>
            {
                new Client
                {
                    RegistrationDate = DateTime.UtcNow,
                    Abonement = null,

                    FirstName = "Name1",
                    SecondName = "Surname1",
                    Age = 35,
                    Phone = new Phone
                    {
                        CountryCode = 375,
                        OperatorCode = 29,
                        PhoneNumber = 1234567
                    },
                    Address = new Address
                    {
                        Country = "Belarus",
                        StreetName = "Belinskogo",
                        Housing = 30
                    }
                },
                new Client
                {
                    RegistrationDate = DateTime.UtcNow,
                    Abonement = new Abonement(AbonementType.MonthOne),

                    FirstName = "Name2",
                    SecondName = "Surname2",
                    Age = 20,
                    Phone = new Phone
                    {
                        CountryCode = 375,
                        OperatorCode = 29,
                        PhoneNumber = 9876543
                    },
                    Address = new Address
                    {
                        Country = "Belarus",
                        StreetName = "pr. Pobeditelei",
                        Housing = 51
                    }
                }
            };

            var employees = new List<Employee>()
            {
                new Employee
                {
                    EnrollmentDate = DateTime.UtcNow,
                    LastPayoutDate = null,

                    FirstName = "Name3",
                    SecondName = "Surname3",
                    Age = 50,
                    Phone = new Phone
                    {
                        CountryCode = 375,
                        OperatorCode = 29,
                        PhoneNumber = 2345678
                    },
                    Address = new Address
                    {
                        Country = "Belarus",
                        StreetName = "J. Kolasa",
                        Housing = 24
                    }
                }
            };

            var club = new Club
            {
                Name = "Zeus",
                Address = new Address
                {
                    Country = "Belarus",
                    StreetName = "L. Bedi",
                    Housing = 18
                },
                Employees = employees,
                Clients = clients
            };
            try
            {
                db.Clubs.Add(club);
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                    eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                        ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (DbUpdateException e)
            {
                //Add your code to inspect the inner exception and/or
                //e.Entries here.
                //Or just use the debugger.
                //Added this catch (after the comments below) to make it more obvious 
                //how this code might help this specific problem
                System.Diagnostics.Debug.WriteLine(e.InnerException.Message);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                throw;
            }

        }
    }
}
