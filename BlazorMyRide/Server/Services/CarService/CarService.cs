using BlazorMyRide.Server.Data;

namespace BlazorMyRide.Server.Services.CarService
{
    public class CarService : ICarService
    {
        private readonly BlazorMyRideDbContext _dbContext;
        public CarService(BlazorMyRideDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Car> CreateCar(Car car)
        {
            car.Custom = null;

            _dbContext.Cars.Add(car);
            await _dbContext.SaveChangesAsync();

            return car;
        }

        public async Task<bool> DeleteCar(int id)
        {
            var dbCar = await _dbContext.Cars
                .Include(ca => ca.Custom)
                .FirstOrDefaultAsync(ca => ca.Id == id);

            if(dbCar is null)
            {
                return false;
            }

            dbCar.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Car?> GetCarById(int id)
        {
            var dbCar = await _dbContext.Cars
                .Include(ca => ca.Custom)
                .FirstOrDefaultAsync(ca => ca.Id == id);

            if(dbCar is null)
            {
                return null;
            }

            return dbCar;
        }

        public async Task<List<Car>> GetCars()
        {
            return await _dbContext.Cars
                .Where(ca => !ca.IsDeleted)
                .Include(ca => ca.Custom)
                .ToListAsync();
        }

        public async Task<Car?> UpdateCar(int id, Car car)
        {
            var dbCar = await _dbContext.Cars
                .Include(ca => ca.Custom)
                .FirstOrDefaultAsync(ca => ca.Id == id);

            if(dbCar is null)
            {
                return null;
            }

            dbCar.VIN = car.VIN;
            dbCar.LicensePlate = car.LicensePlate;
            dbCar.Make = car.Make;
            dbCar.Model = car.Model;
            dbCar.Color = car.Color;
            dbCar.CustomId= car.CustomId;

            await _dbContext.SaveChangesAsync();
            return car;
        }
    }
}
