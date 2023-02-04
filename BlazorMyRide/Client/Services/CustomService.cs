using Microsoft.AspNetCore.Components;

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

        public Task GetCustoms()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustom(int id, Custom custom)
        {
            throw new NotImplementedException();
        }
    }
}
