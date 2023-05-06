using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Tools;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public UserController(AplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> UserLogin([FromBody] UserLogin userLogin)
        {
            try
            {
                string password = PasswordHash.HashPassword(userLogin.Password);
                var dbUser = _context.User.Where(u => u.Username == userLogin.Username && u.Password == password).Select(u => new
                {
                    u.Role,
                    u.Username
                }).FirstOrDefault();
                if (dbUser == null)
                {
                    return BadRequest("Username or Password is Incorrect");
                }
                var authClaims = new List<Claim>{
                    new Claim(ClaimTypes.Name,dbUser.Username),
                    new Claim(ClaimTypes.Role,dbUser.Role)
                };
                var token = GetToken(authClaims);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> UserRegister([FromBody] UserRegister user)
        {
            try
            {
                var dbUser = _context.User.Where(u => u.Username == user.Username).FirstOrDefault();
                if (dbUser != null)
                {
                    return BadRequest("Username already exists");
                }
                user.Password = PasswordHash.HashPassword(user.Password);
                _context.User.Add(user);
                await _context.SaveChangesAsync();
                return Ok("User is succefully registered");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        private JwtSecurityToken GetToken(List<Claim> authclaim)
        {
            var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:secret"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(60),
                claims: authclaim,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256)
                );
            return token;
        }


    }
}
