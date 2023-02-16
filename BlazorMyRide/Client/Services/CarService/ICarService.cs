namespace BlazorMyRide.Client.Services.CarService
{
    public interface ICarService
    {
        List<Car> Cars { get; set; }
        Task GetCars();
        Task<Car?> GetCarById(int id);
        Task AddCar(Car car);
        Task UpdateCar(int id, Car car);
        Task DeleteCar(int id);
    }
}