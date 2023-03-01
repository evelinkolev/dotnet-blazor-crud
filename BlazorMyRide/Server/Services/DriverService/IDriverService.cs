namespace BlazorMyRide.Server.Services.DriverService
{
    public interface IDriverService
    {
        Task<List<Driver>> GetDrivers();
        Task<Driver?> GetDriverById(int id);
        Task<Driver> CreateDriver(Driver driver);
        Task<Driver?> UpdateDriver(int id, Driver driver);
        Task<bool> DeleteDriver(int id);
    }
}
