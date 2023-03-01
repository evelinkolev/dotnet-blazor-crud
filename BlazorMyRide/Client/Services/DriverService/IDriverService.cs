namespace BlazorMyRide.Client.Services.DriverService
{
    public interface IDriverService
    {
        List<Driver> Drivers { get; set; }
        Task GetDrivers();
        Task<Driver?> GetDriverById(int id);
        Task AddDriver(Driver driver);
        Task UpdateDriver(int id, Driver driver);
        Task DeleteDriver(int id);
    }
}