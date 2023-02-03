using BlazorMyRide.Server.Data;

namespace BlazorMyRide.Server.Services
{
    public class CustomService : ICustomService
    {
        private readonly BlazorMyRideDbContext _dbContext;

        public CustomService(BlazorMyRideDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Custom> CreateCustom(Custom custom)
        {
            _dbContext.Add(custom);
            await _dbContext.SaveChangesAsync();
            return custom;
        }

        public async Task<bool> DeleteCustom(int id)
        {
            var dbCustom = await _dbContext.Customs.FindAsync(id);

            if(dbCustom is null)
            {
                return false;
            }

            _dbContext.Remove(dbCustom);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Custom?> GetCustomByID(int id)
        {
            var dbCustom = await _dbContext.Customs.FindAsync(id);
            return dbCustom;
        }

        public async Task<List<Custom>> GetCustoms()
        {
            return await _dbContext.Customs.ToListAsync();
        }

        public async Task<Custom?> UpdateCustom(int id, Custom custom)
        {
            var dbCustom = await _dbContext.Customs.FindAsync(id);

            if(dbCustom is not null)
            {
                dbCustom.Description = custom.Description;
                dbCustom.Price = custom.Price;
            }

            await _dbContext.SaveChangesAsync();
            return custom;
        }
    }
}
