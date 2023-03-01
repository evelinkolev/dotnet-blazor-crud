namespace BlazorMyRide.Server.Data
{
    public class BlazorMyRideDbContext : DbContext
    {
        public BlazorMyRideDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().HasKey(d => new { d.Id });

            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    Id = 1,
                    FullName = "Teodora Testova",
                    Gender = "female",
                    Phone = "123-456-789",
                    Address = "Strelbishte District",
                    Email = "testova.teodora@gmail.com",
                    NationalCardNumber = "Pending Edit",
                    PIN = "Pending Edit",
                    IsDeleted = false,
                    CarId = 1
                },
                new Driver
                {
                    Id = 2,
                    FullName = "Edit or Delete",
                    Gender = "Edit or Delete",
                    Phone = "Edit or Delete",
                    Address = "Edit or Delete",
                    Email = "Edit or Delete",
                    NationalCardNumber = "Edit or Delete",
                    PIN = "Edit or Delete",
                    IsDeleted = false,
                    CarId = 2
                });

            modelBuilder.Entity<Car>().HasKey(ca => new { ca.Id });

            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    VIN = "KNAGM4AD4G5093398",
                    LicensePlate = "T93398",
                    Make = "Kia",
                    Model = "Optima Hybrid",
                    Color = "Cafe Latte",
                    IsDeleted = false,
                    CustomId = 1
                },
                new Car
                {
                    Id = 2,
                    VIN = "5XYZU3LB6EG133096",
                    LicensePlate = "T33096",
                    Make = "Hyundai",
                    Model = "Santa Fe Sport",
                    Color= "Charcoal",
                    IsDeleted = false,
                    CustomId = 2
                });

            modelBuilder.Entity<Custom>().HasKey(c => new { c.Id });

            modelBuilder.Entity<Custom>().HasData(
                new Custom
                {
                    Id = 1,
                    CreatedDate = DateTime.UtcNow,
                    Description = "Battery Repair and Replacement",
                    IsDeleted = false,
                    Price = 500.00M,

                },
                new Custom
                {
                    Id = 2,
                    CreatedDate = DateTime.UtcNow,
                    Description = "Front side bulbs",
                    IsDeleted = false,
                    Price = 42.66M,
                });               
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Custom> Customs { get; set;}
    }
}
