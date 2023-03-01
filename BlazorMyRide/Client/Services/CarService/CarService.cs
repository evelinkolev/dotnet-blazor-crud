using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;

namespace BlazorMyRide.Client.Services.CarService
{
    public class CarService : ICarService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        public CarService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public List<Car> Cars { get; set ; } = new List<Car>();

        public async Task AddCar(Car car)
        {
            await _httpClient.PostAsJsonAsync("api/car/new", car);
            _navigationManager.NavigateTo("cars");
        }

        public async Task DeleteCar(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/car/{id}");
            _navigationManager.NavigateTo("cars");
        }

        public async Task<Car?> GetCarById(int id)
        {
            var result = await _httpClient.GetAsync($"api/car/{id}");
            if(result.StatusCode is HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Car>();
            }
            return null;
        }

        public async Task GetCars()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Car>>("api/car");
            if(result is not null)
            {
                Cars = result;
            }
        }

        public async Task UpdateCar(int id, Car car)
        {
            await _httpClient.PutAsJsonAsync($"api/car/{id}", car);
            _navigationManager.NavigateTo("cars");
        }
    }
}
