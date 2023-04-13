namespace ECommBlazor1.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(string username, string password);
        Task<bool> UserExists(string email);
    }
}
