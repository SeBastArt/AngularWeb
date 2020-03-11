using AngularWeb.Services;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<WeatherForecast> WeatherForecasts { get; set; } = new List<WeatherForecast>();
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hmac = new System.Security.Cryptography.HMACSHA512();
            Randomizer.Seed = new Random(8675309);
            
            List<Guid> GuidList = new List<Guid>();
            GuidList.Add(new Guid("21a56184-0170-4d04-9280-0a57729a62d5"));
            GuidList.Add(new Guid("c3099f2d-6dcb-4608-9b35-4270abc2dff7"));
            GuidList.Add(new Guid("730b0202-2cf5-4b95-aa0e-6f7a0c662f12"));
            GuidList.Add(new Guid("e534fafd-6223-4deb-99e3-c15960a84ac8"));
            GuidList.Add(new Guid("8c677d99-1c3c-4552-9497-2ddc5a826b6e"));
           
            var index = 0;
            var testUser = new Faker<User>()
                .RuleFor(item => item.Id, faker => GuidList[index++])
                .RuleFor(item => item.Username, faker => faker.Name.FirstName())
                .RuleFor(item => item.FirstName, faker => faker.Name.FirstName())
                .RuleFor(item => item.LastName, faker => faker.Name.LastName())
                .RuleFor(item => item.PasswordHash, hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("password")))
                .RuleFor(item => item.PasswordSalt, hmac.Key)
                .RuleFor(item => item.Role, "Admin");

            IEnumerable<User> myUsers = testUser.Generate(4).ToList<User>();

            builder.ToTable("User");
            builder.HasData(myUsers);
            builder.HasData(new User { 
                Id = GuidList[index++], 
                Username = "user",
                FirstName = "Sebastian",
                LastName = "Schüler",
                Role = "Admin",
                PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("password")),
                PasswordSalt = hmac.Key 
            });
        }
    }
}
