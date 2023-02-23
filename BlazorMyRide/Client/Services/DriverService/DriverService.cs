using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;

namespace BlazorMyRide.Client.Services.DriverService
{
    public class DriverService : IDriverService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        public DriverService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public List<Driver> Drivers { get; set; } = new List<Driver>();

        public async Task AddDriver(Driver driver)
        {
            await _httpClient.PostAsJsonAsync("api/driver/new", driver);
            _navigationManager.NavigateTo("drivers");
        }

        public async Task DeleteDriver(int id)
        {
            await _httpClient.DeleteAsync($"api/driver/{id}");
            _navigationManager.NavigateTo("drivers");
        }

        public async Task<Driver?> GetDriverById(int id)
        {
            var result = await _httpClient.GetAsync($"api/driver/{id}");
            if(result.StatusCode is HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Driver>();
            }
            return null;
        }

        public async Task GetDrivers()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Driver>>("api/driver");
            if(result is not null)
            {
                Drivers = result;
            }
        }

        public async Task UpdateDriver(int id, Driver driver)
        {
            await _httpClient.PutAsJsonAsync($"api/driver/{id}", driver);
            _navigationManager.NavigateTo("drivers");
        }
    }
}
