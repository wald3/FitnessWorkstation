using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFitness.Context;
using DbFitness.Models;

namespace DbFitness.Initializer
{
    class DbInitializer : CreateDatabaseIfNotExists<DbFitnessСontext>
    {
        protected override void Seed(DbFitnessСontext db)
        {
            var persons = new List<Person>
            {
                new Person
                {
                    PersonInfo = new PersonInfo
                    {
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
                    }
                },
                new Person
                {
                    PersonInfo = new PersonInfo
                    {
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
                },
                new Person
                {
                    PersonInfo = new PersonInfo
                    {
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
                },

            };

            var club = new Club
            {
                ClubName = "Zeus",
                Address = new Address
                {
                    Country = "Belarus",
                    StreetName = "L. Bedi",
                    Housing = 18
                },
                Persons = persons
            };

            db.Clubs.Add(club);
            db.SaveChanges();
        }

        //public static void Initialize(DbFitnessСontext db)
        //{
        //    if (db.Database.Exists())
        //        db.Database.Delete();
        //    db.Database.Create();

        //    var persons = new List<Person>
        //    {
        //        new Person
        //        {
        //            PersonInfo = new PersonInfo
        //            {
        //                FirstName = "Name1",
        //                SecondName = "Surname1",
        //                Age = 35,
        //                Phone = new Phone
        //                {
        //                    CountryCode = 375,
        //                    OperatorCode = 29,
        //                    PhoneNumber = 1234567
        //                },
        //                Address = new Address
        //                {
        //                    Country = "Belarus",
        //                    StreetName = "Belinskogo",
        //                    Housing = 30
        //                }
        //            }
        //        },
        //        new Person
        //        {
        //            PersonInfo = new PersonInfo
        //            {
        //                FirstName = "Name2",
        //                SecondName = "Surname2",
        //                Age = 20,
        //                Phone = new Phone
        //                {
        //                    CountryCode = 375,
        //                    OperatorCode = 29,
        //                    PhoneNumber = 9876543
        //                },
        //                Address = new Address
        //                {
        //                    Country = "Belarus",
        //                    StreetName = "pr. Pobeditelei",
        //                    Housing = 51
        //                }
        //            }
        //        },
        //        new Person
        //        {
        //            PersonInfo = new PersonInfo
        //            {
        //                FirstName = "Name3",
        //                SecondName = "Surname3",
        //                Age = 50,
        //                Phone = new Phone
        //                {
        //                    CountryCode = 375,
        //                    OperatorCode = 29,
        //                    PhoneNumber = 2345678
        //                },
        //                Address = new Address
        //                {
        //                    Country = "Belarus",
        //                    StreetName = "J. Kolasa",
        //                    Housing = 24
        //                }
        //            }
        //        },

        //    };

        //    var club = new Club
        //    {
        //        ClubName = "Zeus",
        //        Address = new Address
        //        {
        //            Country = "Belarus",
        //            StreetName = "L. Bedi",
        //            Housing = 18
        //        },
        //        Persons = persons
        //    };

        //    db.Clubs.Add(club);
        //    db.SaveChanges();
        //}
    }
}
