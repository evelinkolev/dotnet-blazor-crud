namespace BlazorMyRide.Server.Services.CustomService
{
    public interface ICustomService
    {
        Task<List<Custom>> GetCustoms();
        Task<Custom?> GetCustomByID(int id);
        Task<Custom> CreateCustom(Custom custom);
        Task<Custom?> UpdateCustom(int id, Custom custom);
        Task<bool> DeleteCustom(int id);
    }
}
