using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using backend.Database;
using backend.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public AuthController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private static string HashPasswd(string str)
        {
            using var sha256 = SHA256.Create();
            var hashedBytesSha256 = sha256.ComputeHash(Encoding.UTF8.GetBytes(str));
            return Convert.ToBase64String(hashedBytesSha256);
        }
        [HttpPost("regist")]
        public async Task<IActionResult> RegisterUser([FromBody] User vUser)
        {
            if (_dbContext.Users.Any(n => n.Email == vUser.Email))
            {
                return BadRequest(new {mass = "Пользователь с таким email уже существует" });
            }

            var hashedPassword = HashPasswd(vUser.Passwd);
            
            var newUser = new User
            {
                Id = Guid.NewGuid(),
                Email = vUser.Email,
                Passwd = hashedPassword,
                RememberMe = vUser.RememberMe
            };
            
            await _dbContext.Users.AddAsync(newUser);
            await _dbContext.SaveChangesAsync();
            
            return Ok(new { message = "Регистрация прошла успешно." });
        }
        [HttpPost("login")] 
        public async Task<IActionResult> LogInUser([FromBody]User lUser, bool rememberMe)
        {
            var user = await _dbContext.Users.FirstAsync(u => u.Email == lUser.Email);
            
            if (string.IsNullOrEmpty(user.Email))
            {
                return Ok(new { status = false, mes = "Error null" }); 
            }

            var userPasswd = HashPasswd(lUser.Passwd);
            user.RememberMe = rememberMe;
            await _dbContext.SaveChangesAsync();
            
            return userPasswd == user.Passwd ? Ok(new { jwtlow = true, rem = rememberMe, mes ="success"}) : Ok(new {mes = "fail"});
        }

        [HttpPost("logout")]
        public async Task<IActionResult> LogOut(User lUser)
        {
            var user = await _dbContext.Users.FirstAsync(u => u.Email == lUser.Email);
            if (!user.RememberMe) return Ok(new { mes = "fail, your not auth" });
            user.RememberMe = false;
            await _dbContext.SaveChangesAsync();
            return Ok(new{jwtlow = false, rem = false});

        }
    }
    
}
