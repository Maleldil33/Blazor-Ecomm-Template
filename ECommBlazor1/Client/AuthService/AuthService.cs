using ECommBlazor1.Shared.Models;
using ECommBlazor1.Shared.DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using Blazored.LocalStorage;

namespace ECommBlazor1.Client.AuthService
{
    public class AuthService : IAuthService
    {
        
        private ILocalStorageService LocalStorage;
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        private readonly AuthenticationStateProvider _authStateProvider;

        public AuthService(HttpClient http, NavigationManager navigationManager, AuthenticationStateProvider authStateProvider)
        {
            _http = http;
            _navigationManager = navigationManager;
            _authStateProvider = authStateProvider;
        }

        public User User { get; set; } = new User();
        public List<User> Users { get; set; } = new List<User>();

        public async void LoginCallback()
        {
            string token = await LocalStorage.GetItemAsync<string>("token"); 
        }

        public async Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/change-password", request.Password);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

        public async Task<bool> IsUserAuthenticated()
        {
            return (await _authStateProvider.GetAuthenticationStateAsync()).User.Identity.IsAuthenticated;
        }

        public async Task<ServiceResponse<string>> Login(UserLoginDTO request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }
        public async Task<ServiceResponse<int>> Register(UserRegisterDTO request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }


        private async Task SetUsers(HttpResponseMessage result)
        {
            try
            {
                string response = await result.Content.ReadAsStringAsync();
                Console.WriteLine(response);

                _navigationManager.NavigateTo("/");
            }
            catch (Exception e)
            {
                Console.WriteLine("User could not be set");

                Console.WriteLine(User);
                Console.WriteLine(result);
            }                       
        }        
    }
}