namespace BlazorMyRide.Server.Services.CarService
{
    public interface ICarService
    {
        Task<List<Car>> GetCars();
        Task<Car?> GetCarById(int id);
        Task<Car> CreateCar(Car car);
        Task<Car?> UpdateCar(int id, Car car);
        Task<bool> DeleteCar(int id);
    }
}