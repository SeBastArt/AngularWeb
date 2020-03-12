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
namespace AngularWeb.Data
{
    public class DataContext : AuditDbContext
    {
        protected readonly IConfiguration _configuration;
        private readonly ILoggerFactory _loggerFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;


        //Document
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentPosition> DocumentPositions { get; set; }

        //Address
        public DbSet<Address> Addresss { get; set; }
        public DbSet<AddressCompanyType> AddressCompanyTypes { get; set; }
        public DbSet<AddressCountry> AddressCountries { get; set; }
        public DbSet<AddressPerson> AddresssPersons { get; set; }
        

        //Article
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleGroup> ArticleGroups { get; set; }
        public DbSet<ArticleInventory> ArticleInventorys { get; set; }
        public DbSet<ArticlePlace> ArticlePlaces { get; set; }
        public DbSet<ArticlePriceListIn> ArticlePriceListIns { get; set; }
        public DbSet<ArticlePriceListOut> ArticlePriceListOuts { get; set; }
        public DbSet<ArticleRange> ArticleRanges { get; set; }
        public DbSet<ArticleText> ArticleTexts { get; set; }
        public DbSet<ArticleType> ArticleType { get; set; }

        //Misc
        public DbSet<FAGBinary> FagBinarys { get; set; }
        public DbSet<User> Users { get; set; }
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

                //modelBuilder.Entity<ArticleType>()
                //.HasOne(b => b.Article)
                //.WithOne(a => a.ArticleType)
                //.IsRequired()
                //.OnDelete(DeleteBehavior.NoAction);

                modelBuilder.ApplyConfiguration(new UserConfiguration());
                modelBuilder.ApplyConfiguration(new WeatherForecastConfiguration());
                modelBuilder.ApplyConfiguration(new Audit_WeatherForecastConfiguration());

                foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                {
                    relationship.DeleteBehavior = DeleteBehavior.Restrict;
                }
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
