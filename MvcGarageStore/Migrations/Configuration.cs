namespace MvcGarageStore.Migrations
{
    using MvcGarageStore.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing;
    using System.Linq;
    using System.Web.Security;
    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcGarageStore.Models.GarageDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MvcGarageStore.Models.GarageDb context)
        {
            context.Categories.AddOrUpdate(c => c.Name,
                new Category
                {
                    Id = 1,
                    Name = "Family",
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle 
                        {
                            Id = 1,
                            Automatic = true,
                            DateRelease = new DateTime(2014,2,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "alto.jpg",
                            Model = "Suzuki",
                            Price = 50,
                            Type = "Alto",
                            CategoryId = 1,
                            Kilometer = 1000,
                            Doors = 4,
                            Color = Color.AliceBlue
                        },
                        new Vehicle 
                        {
                            Id = 1,
                            Automatic = true,
                            DateRelease = new DateTime(2014,2,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "AVENSIS.jpg",
                            Model = "Toyota",
                            Price = 66,
                            Type = "Avensis",
                            CategoryId = 1,
                            Kilometer = 1000,
                            Doors = 4,
                            Color = Color.Gray
                        },
                        new Vehicle 
                        {
                            Id = 1,
                            Automatic = true,
                            DateRelease = new DateTime(2014,2,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "i10.jpg",
                            Model = "Hyundai",
                            Price = 56,
                            Type = "I10",
                            CategoryId = 1,
                            Kilometer = 1000,
                            Doors = 4,
                            Color = Color.Silver
                        },
                        new Vehicle 
                        {
                            Id = 1,
                            Automatic = true,
                            DateRelease = new DateTime(2014,2,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "i20.jpg",
                            Model = "Hyundai",
                            Price = 56,
                            Type = "I20",
                            CategoryId = 1,
                            Kilometer = 1000,
                            Doors = 4,
                            Color = Color.Silver
                        },
                        new Vehicle 
                        {
                            Id = 1,
                            Automatic = true,
                            DateRelease = new DateTime(2014,2,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "i30.jpg",
                            Model = "Hyundai",
                            Price = 56,
                            Type = "I30",
                            CategoryId = 1,
                            Kilometer = 1000,
                            Doors = 4,
                            Color = Color.Black
                        },
                        new Vehicle 
                        {
                            Id = 1,
                            Automatic = true,
                            DateRelease = new DateTime(2014,2,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "mazda2.jpg",
                            Model = "Mazda",
                            Price = 56,
                            Type = "2",
                            CategoryId = 1,
                            Kilometer = 1000,
                            Doors = 4,
                            Color = Color.Green
                        },
                        new Vehicle 
                        {
                            Id = 1,
                            Automatic = true,
                            DateRelease = new DateTime(2014,2,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "mazda3.jpg",
                            Model = "Mazda",
                            Price = 56,
                            Type = "3",
                            CategoryId = 1,
                            Kilometer = 1000,
                            Doors = 4,
                            Color = Color.Silver
                        },
                        new Vehicle 
                        {
                            Id = 1,
                            Automatic = true,
                            DateRelease = new DateTime(2014,2,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "mazda5.jpg",
                            Model = "Mazda5",
                            Price = 56,
                            Type = "5",
                            CategoryId = 1,
                            Kilometer = 1000,
                            Doors = 4,
                            Color = Color.Silver
                        },
                        new Vehicle 
                        {
                            Id = 1,
                            Automatic = true,
                            DateRelease = new DateTime(2014,2,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "mazda6.jpg",
                            Model = "Mazda6",
                            Price = 56,
                            Type = "6",
                            CategoryId = 1,
                            Kilometer = 1000,
                            Doors = 4,
                            Color = Color.White
                        }
                    }
                },
                new Category
                {
                    Id = 2,
                    Name = "Manager",
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle 
                        {
                            Id = 2,
                            Automatic = false,
                            DateRelease = new DateTime(2013,2,13),
                            EngineCapacity = 1200,
                            EngineType = "Benzine",
                            ImageUrl = "cts.jpg",
                            Model = "Jugar",
                            Price = 85,
                            Type = "CTS",
                            CategoryId = 2,
                            Kilometer = 10300,
                            Doors = 4,
                            Color = Color.Red
                        },
                        new Vehicle 
                        {
                            Id = 3,
                            Automatic = true,
                            DateRelease = new DateTime(2013,9,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "rio.jpg",
                            Model = "Kia",
                            Price = 50,
                            Type = "Rio",
                            CategoryId = 2,
                            Kilometer = 3200,
                            Doors = 4,
                            Color = Color.Red
                        },
                        new Vehicle 
                        {
                            Id = 3,
                            Automatic = true,
                            DateRelease = new DateTime(2013,9,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "saloon.jpg",
                            Model = "Jaguar",
                            Price = 50,
                            Type = "Saloon",
                            CategoryId = 2,
                            Kilometer = 3200,
                            Doors = 4,
                            Color = Color.Black
                        },
                        new Vehicle 
                        {
                            Id = 3,
                            Automatic = true,
                            DateRelease = new DateTime(2013,9,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "i40saloon.png",
                            Model = "Hyundai",
                            Price = 50,
                            Type = "I40",
                            CategoryId = 2,
                            Kilometer = 3200,
                            Doors = 4,
                            Color = Color.Silver
                        }
                    }
                },
                new Category
                {
                    Id = 3,
                    Name = "Van",
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle 
                        {
                            Id = 2,
                            Automatic = false,
                            DateRelease = new DateTime(2013,2,13),
                            EngineCapacity = 1200,
                            EngineType = "Diesel",
                            ImageUrl = "CitroenRelay.jpg",
                            Model = "Citroen",
                            Price = 85,
                            Type = "Relay",
                            CategoryId = 3,
                            Kilometer = 10300,
                            Doors = 4,
                            Color = Color.White
                        },
                        new Vehicle 
                        {
                            Id = 3,
                            Automatic = true,
                            DateRelease = new DateTime(2013,9,23),
                            EngineCapacity = 1000,
                            EngineType = "Diesel",
                            ImageUrl = "iveco-van12.jpg",
                            Model = "Fiat",
                            Price = 50,
                            Type = "Iveco",
                            CategoryId = 3,
                            Kilometer = 3200,
                            Doors = 3,
                            Color = Color.Red
                        },
                        new Vehicle 
                        {
                            Id = 3,
                            Automatic = true,
                            DateRelease = new DateTime(2013,9,23),
                            EngineCapacity = 1000,
                            EngineType = "Diesel",
                            ImageUrl = "saloon.jpg",
                            Model = "Fiat",
                            Price = 50,
                            Type = "Iveco-daily",
                            CategoryId = 3,
                            Kilometer = 3200,
                            Doors = 3,
                            Color = Color.Green
                        }
                    }
                },
                new Category
                {
                    Id = 4,
                    Name = "Mini",
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle 
                        {
                            Id = 2,
                            Automatic = false,
                            DateRelease = new DateTime(2013,2,13),
                            EngineCapacity = 1200,
                            EngineType = "Benzine",
                            ImageUrl = "Toyota-Yaris.jpg",
                            Model = "Toyota",
                            Price = 85,
                            Type = "Yaris",
                            CategoryId = 4,
                            Kilometer = 10300,
                            Doors = 4,
                            Color = Color.Silver
                        },
                        new Vehicle 
                        {
                            Id = 3,
                            Automatic = true,
                            DateRelease = new DateTime(2013,9,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "Mini_Cooper.jpeg",
                            Model = "Mini",
                            Price = 50,
                            Type = "Cooper",
                            CategoryId = 4,
                            Kilometer = 3200,
                            Doors = 2,
                            Color = Color.Red
                        },
                        new Vehicle 
                        {
                            Id = 3,
                            Automatic = true,
                            DateRelease = new DateTime(2013,9,23),
                            EngineCapacity = 1000,
                            EngineType = "Benzine",
                            ImageUrl = "toyota-iq.jpg",
                            Model = "Toyota",
                            Price = 50,
                            Type = "IQ",
                            CategoryId = 4,
                            Kilometer = 3200,
                            Doors = 2,
                            Color = Color.Green
                        }
                    }
                }
                );

            SeedMembership();
        }

        private void SeedMembership()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "userId", "UserName", autoCreateTables: true);
            }

            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if (!roles.RoleExists("Admin"))
            {
                roles.CreateRole("Admin");
            }
            if (membership.GetUser("Matan", false) == null)
            {
                membership.CreateUserAndAccount("Matan", "Password1");
            }
            if (!roles.GetRolesForUser("Matan").Contains("Admin"))
            {
                roles.AddUsersToRoles(new[] { "Matan" }, new[] { "Admin" });
            }
        }
    }
}
