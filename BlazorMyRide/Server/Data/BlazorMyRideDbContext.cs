namespace BlazorMyRide.Server.Data
{
    public class BlazorMyRideDbContext : DbContext
    {
        public BlazorMyRideDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
    }
}
