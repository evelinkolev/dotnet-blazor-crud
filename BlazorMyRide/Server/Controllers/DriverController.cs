using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMyRide.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        [HttpGet]
        public async Task<List<Driver>> GetDrivers()
        {
            return await _driverService.GetDrivers();
        }

        [HttpGet("{id}")]
        public async Task<Driver?> GetDriverById(int id)
        {
            return await _driverService.GetDriverById(id);
        }

        [HttpPost("new")]
        public async Task<Driver?> CreateDriver(Driver driver)
        {
            return await _driverService.CreateDriver(driver);
        }

        [HttpPut("{id}")]
        public async Task<Driver?> UpdateDriver(int id, Driver driver)
        {
            return await _driverService.UpdateDriver(id, driver);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteDriver(int id)
        {
            return await _driverService.DeleteDriver(id);
        }
    }
}
