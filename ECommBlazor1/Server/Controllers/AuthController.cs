using Microsoft.AspNetCore.Mvc;
using ECommBlazor1.Shared.Models;
using ECommBlazor1.Shared.DTO;
using System.Security.Cryptography;

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace ECommBlazor1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        public static User user = new User();
        private readonly IConfiguration _configuration;

        private readonly DataContext _context;

        public AuthController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            if (users == null)
            {
                return NotFound("No users could be retrieved");
            }

            return Ok(users);

        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDTO request)
        {

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                return NotFound("User doesn't exist");
            }

            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt, request.Email))
            {
                return NotFound("passwords do not match");
            }

            else
            {

                string jwt = CreateToken(user);

                return jwt;
            }

        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> RegisterUser(UserDTO request)
        {
            if (_context.Users.Any(u => u.Email == request.Email))
            {
                //Felmeddelande bör implementeras
                
                return BadRequest("A user with that email already exists");
            }

            if (request.Password == request.ConfirmPassword)
            {

                CreatePasswordHash(request.Password, out byte[] PasswordHash, out byte[] PasswordSalt, request.Email);

                var user = new User
                {                    
                    Email = request.Email,
                    PasswordHash = PasswordHash,
                    PasswordSalt = PasswordSalt,

                };

                _context.Add(user);
                await _context.SaveChangesAsync();

                return user;
            }

            else
            {
                return BadRequest("Passwords do not match");
            }

        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt, string email)
        {
            using (var hmac = new HMACSHA512())
            {
                Console.WriteLine(password);
                
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                Console.WriteLine(password);

            }

        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt, string email)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        // Varje användare tilldelas ett namn som claim som är detsamma som namnet som anges vid reg
        // och dessutom tilldelas alltid som roll 'user'.
        // Claims kan användas för att låta programmet att ändra betende mot olika claims
        // "accountid" används för att indentifiera från vilkte kontonr fakturor ska hämtas
        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Role, "User"),                
            };            

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("Jwt:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);            

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims
                );

            string jwtToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
        
        private string CreateEmailToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }

        private async Task<List<User>> GetDbUsers()
        {
            return await _context.Users.ToListAsync();
        }

    }
}
