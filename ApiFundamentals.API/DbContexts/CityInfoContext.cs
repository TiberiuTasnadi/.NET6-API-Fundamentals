using ApiFundamentals.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiFundamentals.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                    new City("New York")
                    {
                        Id = 1,
                        Description = "Description"
                    },
                    new City("New York2")
                    {
                        Id = 2,
                        Description = "Description2"
                    });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                      new PointOfInterest("New York POI")
                      {
                          Id = 1,
                          Description = "Description POI",
                          CityId = 1
                      },
                      new PointOfInterest("New York2 POI")
                      {
                          Id = 2,
                          Description = "Description2 POI",
                          CityId = 2
                      });

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionString");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
