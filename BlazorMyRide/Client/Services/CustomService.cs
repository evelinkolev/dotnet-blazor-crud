using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorMyRide.Client.Services
{
    public class CustomService : ICutomService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        public CustomService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public List<Custom> Customs { get; set; } = new List<Custom>();

        public Task AddCustom(Custom custom)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Custom?> GetCustomById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetCustoms()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Custom>>("api/custom");
            if(result is not null)
            {
                Customs = result;
            }
        }

        public Task UpdateCustom(int id, Custom custom)
        {
            throw new NotImplementedException();
        }
    }
}
