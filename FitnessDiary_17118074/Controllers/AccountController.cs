using FitnessDiary_17118074.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Controllers
{
    [ApiController]    
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;


        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("api/register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Ok(model);
            }

            var user = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            var role = await _userManager.AddToRoleAsync(user, "Client");

            if (!result.Succeeded)
            {
                return BadRequest(model);
            }

            await _signInManager.SignInAsync(user, isPersistent: false);

            return Ok();
        }

        [AllowAnonymous]
        [Route("api/login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return Ok(user);
            }

            var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);

            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(user);
        }

        [AllowAnonymous]
        [Route("api/logout")]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Ok();
        }
    }
}
