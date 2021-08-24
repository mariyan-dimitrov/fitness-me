using FitnessMe_15118078.Models.ViewModels;
using FitnessMe_15118078.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessMe_15118078.Common;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace FitnessMe_15118078.Controllers
{
    [ApiController]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly JwtTokenGenerator _jwtTokenGenerator;

        public AccountController(UserManager<IdentityUser> userManager,
                                 SignInManager<IdentityUser> signInManager,
                                 JwtTokenGenerator jwtTokenGenerator)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenGenerator = jwtTokenGenerator;
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

            IdentityResult creationUserResult = await _userManager.CreateAsync(user, model.Password);
            if (!creationUserResult.Succeeded)
            {
                return BadRequest($"Cannot create user. [{string.Join(',', creationUserResult.Errors.Select(x => x.Description))}]");
            }

            IdentityResult assignUserToRoleResult = await _userManager.AddToRoleAsync(user, Constants.Roles.User);
            if (!assignUserToRoleResult.Succeeded)
            {
                return BadRequest($"Cannot create user assign user to role User[{string.Join(',', assignUserToRoleResult.Errors.Select(x => x.Description))}]");
            }

            await _signInManager.SignInAsync(user, isPersistent: false);

            return Ok(_jwtTokenGenerator.Generate(user, new List<string>() { Constants.Roles.User }));
        }

        [AllowAnonymous]
        [Route("api/login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginUserViewModel)
        {
            if (!ModelState.IsValid)
            {
                return Ok(loginUserViewModel);
            }

            SignInResult result = await _signInManager.PasswordSignInAsync(loginUserViewModel.Email, loginUserViewModel.Password, loginUserViewModel.RememberMe, false);
            if (!result.Succeeded)
            {
                return BadRequest("Incorrect user name or password");
            }

            IdentityUser user = await _userManager.Users.SingleOrDefaultAsync(u => u.Email == loginUserViewModel.Email);
            IList<string> userRoles = await _userManager.GetRolesAsync(user);

            return Ok(_jwtTokenGenerator.Generate(user, userRoles));
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
