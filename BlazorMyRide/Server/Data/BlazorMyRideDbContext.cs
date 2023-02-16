namespace BlazorMyRide.Server.Data
{
    public class BlazorMyRideDbContext : DbContext
    {
        public BlazorMyRideDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                    CustomId = 2
                });

            modelBuilder.Entity<Custom>().HasKey(c => new { c.Id });

            modelBuilder.Entity<Custom>().HasData(
                new Custom
                {
                    Id = 1,
                    CreatedDate = DateTime.UtcNow,
                    Description = "Battery Repair and Replacement",
                    Price = 500.00M,

                },
                new Custom
                {
                    Id = 2,
                    CreatedDate = DateTime.UtcNow,
                    Description = "Front side bulbs",
                    Price = 42.66M,
                });               
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Custom> Customs { get; set;}
    }
}
