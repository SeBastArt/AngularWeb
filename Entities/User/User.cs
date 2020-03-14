using AngularWeb.Services;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        [InverseProperty("User")]
        //public virtual List<WeatherForecast> WeatherForecasts { get; set; }
        public virtual ICollection<WeatherForecast> WeatherForecasts { get; } = new List<WeatherForecast>();
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hmac = new System.Security.Cryptography.HMACSHA512();
            Randomizer.Seed = new Random(8675309);
            int index  = 1;
            var testUser = new Faker<User>()
                .RuleFor(item => item.Id, faker => index++ )
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
                Id = index++, 
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
