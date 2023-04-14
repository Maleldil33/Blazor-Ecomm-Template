using ECommBlazor1.Shared.DTO;
using ECommBlazor1.Shared.Models;

using Microsoft.AspNetCore.Mvc;

namespace ECommBlazor1.Client.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegisterDTO request);
        Task<ServiceResponse<string>> Login(UserLoginDTO request);
        Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request);
        Task<bool> IsUserAuthenticated();

    }
}
