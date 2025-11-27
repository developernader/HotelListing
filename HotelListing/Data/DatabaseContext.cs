
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // This line is crucial!

            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Egypt", ShortName = "EG" },
                new Country { Id = 2, Name = "Bahamas", ShortName = "BS" },
                new Country { Id = 3, Name = "Cayman Island", ShortName = "CI" }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Fairmont Nile City", Address = "1191 Nile Corniche, Souq Al ASR", CountryId = 1, Rating = 8.4 },
                new Hotel { Id = 2, Name = "Comfort Suites", Address = "George Town", CountryId = 3, Rating = 4.3 },
                new Hotel { Id = 3, Name = "Sandals Resort and Spa", Address = "CI", CountryId = 3, Rating = 4.5 }
                );
        }

    }
}
