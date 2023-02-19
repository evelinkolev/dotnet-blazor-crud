namespace BlazorMyRide.Server.Services.DriverService
{
    public class DriverService : IDriverService
    {
        private readonly BlazorMyRideDbContext _dbContext;
        public DriverService(BlazorMyRideDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Driver> CreateDriver(Driver driver)
        {
            driver.Car = null;

            _dbContext.Drivers.Add(driver);
            await _dbContext.SaveChangesAsync();

            return driver;
        }

        public async Task<bool> DeleteDriver(int id)
        {
            var dbDriver = await _dbContext.Drivers
                .Include(d => d.Car)
                .FirstOrDefaultAsync(d => d.Id == id);

            if(dbDriver is null)
            {
                return false;
            }

            dbDriver.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Driver?> GetDriverById(int id)
        {
            var dbDriver = await _dbContext.Drivers
                .Include(d => d.Car)
                .FirstOrDefaultAsync(d => d.Id == id);

            if(dbDriver is null)
            {
                return null;
            }

            return dbDriver;
        }

        public async Task<List<Driver>> GetDrivers()
        {
            return await _dbContext.Drivers
                .Where(d => !d.IsDeleted)
                .Include(d => d.Car)
                .ToListAsync();
        }

        public async Task<Driver?> UpdateDriver(int id, Driver driver)
        {
            var dbDriver = await _dbContext.Drivers
                .Include(d => d.Car)
                .FirstOrDefaultAsync(d => d.Id == id);

            if(dbDriver is null)
            {
                return null;
            }

            dbDriver.FullName = driver.FullName;
            dbDriver.Gender = driver.Gender;
            dbDriver.Phone = driver.Phone;
            dbDriver.Address = driver.Address;
            dbDriver.Email = driver.Email;
            dbDriver.NationalCardNumber = driver.NationalCardNumber;
            dbDriver.PIN = driver.PIN;
            dbDriver.CarId = driver.CarId;

            await _dbContext.SaveChangesAsync();
            return driver;
        }
    }
}
