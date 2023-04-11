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

        public AuthService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;            
        }

        public User User { get; set; } = new User();
        public List<User> Users { get; set; } = new List<User>();

        public async void LoginCallback()
        {
            string token = await LocalStorage.GetItemAsync<string>("token"); 
        }

        public async Task<ActionResult<User>> RegisterUser(UserDTO request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/register", request);
            await SetUsers(result);

            return await result.Content.ReadFromJsonAsync<User>();
        }

        public async Task GetUsers()
        {
            var result = await _http.GetFromJsonAsync<List<User>>("api/auth");
            if (result == null)          
            
            Users = result;            

        }

        public async Task<ActionResult<User>> LoginUser(UserDTO request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", request);

            return await result.Content.ReadFromJsonAsync<User>();

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