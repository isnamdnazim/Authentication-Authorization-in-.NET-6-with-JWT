using System.Security.Cryptography;

namespace AuthenticationWebApi.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public async Task<User> RegisterUser(UserDto request)
        {
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordsalt);
            var user = new User { 
                UserName = request.UserName ,
                PasswordHash = passwordHash,
                PassworSalt = passwordsalt
            };
            return user;
        }

        private void CreatePasswordHash (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
