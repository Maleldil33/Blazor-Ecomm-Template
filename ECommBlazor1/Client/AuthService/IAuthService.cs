using ECommBlazor1.Shared.DTO;
using ECommBlazor1.Shared.Models;

using Microsoft.AspNetCore.Mvc;

namespace ECommBlazor1.Client.AuthService
{
    public interface IAuthService
    {
        List<User> Users { get; set; }
        Task GetUsers(); 
        Task <ActionResult<User>> RegisterUser(UserDTO request);
        Task<ActionResult<User>> LoginUser(UserDTO request);        

    }
}
