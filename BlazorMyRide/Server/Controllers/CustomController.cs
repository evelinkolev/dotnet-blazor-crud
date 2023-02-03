using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMyRide.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        private readonly ICustomService _customService;

        public CustomController(ICustomService customService)
        {
            _customService = customService;
        }

        [HttpGet]
        public async Task<List<Custom>> GetCustoms()
        {
            return await _customService.GetCustoms();
        }

        [HttpGet("{id}")]
        public async Task<Custom?> GetCustomById(int id)
        {
            return await _customService.GetCustomByID(id);
        }
    }
}
