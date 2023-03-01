using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMyRide.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<List<Car>> GetCars()
        {
            return await _carService.GetCars();
        }

        [HttpGet("{id}")]
        public async Task<Car?> GetCarById(int id)
        {
            return await _carService.GetCarById(id);
        }

        [HttpPost("new")]
        public async Task<Car?> CreateCar(Car car)
        {
            return await _carService.CreateCar(car);
        }

        [HttpPut("{id}")]
        public async Task<Car?> UpdateCar(int id, Car car)
        {
            return await _carService.UpdateCar(id, car);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteCar(int id)
        {
            return await _carService.DeleteCar(id);
        }
    }
}
