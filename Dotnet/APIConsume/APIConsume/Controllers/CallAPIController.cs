using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APIConsume.Controllers
{
    public class CallAPIController : Controller
    {
        private const string SecretKey = "MynameisJamesBond0007_MynameisJamesBond007"; // Ensure this is secure
        private const string Issuer = "https://www.yogihosting.com";
        private const string Audience = "dotnetclient";

        // Display Login Page
        [HttpGet]
        public IActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        // Handle Login Form Submission
        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
            // Replace with real authentication logic
            if (username == "secret" && password == "secret")
            {
                var accessToken = GenerateJSONWebToken();
                SetJWTCookie(accessToken);

                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, username)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }

            // Authentication failed
            ViewBag.Message = "Login Failed";
            return View();
        }

        private string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, "user"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: Issuer,
                audience: Audience,
                claims: claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private void SetJWTCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.Now.AddHours(3)
            };
            Response.Cookies.Append("jwtcookie", token, cookieOptions);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            Response.Cookies.Delete("jwtcookie");
            return RedirectToAction("Index");
        }
    }
}
