using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AngularWeb.Entities;
using System;
using Microsoft.Extensions.Logging;
using Audit.EntityFramework;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Globalization;
using AngularWeb.Entities.Address;
using AngularWeb.Entities.User;

namespace AngularWeb.Data
{
    public class DataContext : AuditDbContext
    {
        protected readonly IConfiguration _configuration;
        private readonly ILoggerFactory _loggerFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public DbSet<User> Users { get; set; }
    
        public DbSet<AddressCountry> addressCountries { get; set; }
        public DbSet<AddressCompanyType> addressCompanyTypes { get; set; }
        public DbSet<FAGBinary> fagBinarys { get; set; }
        public DbSet<Address> addresss { get; set; }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public DbSet<Audit_WeatherForecast> AuditWeatherForecasts { get; set; }

        public DataContext(IConfiguration configuration, ILoggerFactory loggerFactory, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _loggerFactory = loggerFactory;
        }

        public override int SaveChanges()
        {
            ApplyAuditInformation();
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder != null) {
                if (!optionsBuilder.IsConfigured)
                { 
                    optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DataContext"));
                    optionsBuilder.UseLoggerFactory(_loggerFactory);
                    optionsBuilder.EnableSensitiveDataLogging(true);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
                modelBuilder.Entity<AddressPersonRelation>()
                    .HasKey(bc => new { bc.AddressId, bc.AddressPersonId });
                modelBuilder.Entity<AddressPersonRelation>()
                    .HasOne(bc => bc.Address)
                    .WithMany(b => b.AddressPersonRelations)
                    .HasForeignKey(bc => bc.AddressId);
                modelBuilder.Entity<AddressPersonRelation>()
                    .HasOne(bc => bc.AddressPerson)
                    .WithMany(c => c.AddressPersonRelations)
                    .HasForeignKey(bc => bc.AddressPersonId);


                modelBuilder.ApplyConfiguration(new UserConfiguration());
                modelBuilder.ApplyConfiguration(new WeatherForecastConfiguration());
                modelBuilder.ApplyConfiguration(new Audit_WeatherForecastConfiguration());
            }

            base.OnModelCreating(modelBuilder);
        }


        private void ApplyAuditInformation()
        {
            var modifiedEntities = ChangeTracker.Entries<BaseEntity>().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
            foreach (var entity in modifiedEntities)
            {
                entity.Property("Modified").CurrentValue = DateTime.UtcNow;
                entity.Property("ModifiedBy").CurrentValue = long.Parse(_httpContextAccessor.HttpContext.User.Identity.Name, NumberStyles.Number, CultureInfo.InvariantCulture);
                if (entity.State == EntityState.Added)
                {
                    entity.Property("Created").CurrentValue = DateTime.UtcNow;
                    entity.Property("CreatedBy").CurrentValue = long.Parse(_httpContextAccessor.HttpContext.User.Identity.Name, NumberStyles.Number, CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
