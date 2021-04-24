using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityServer.Controllers
{
    public class AuthController : Controller
    {
		private readonly SignInManager<IdentityUser> _signInManager;
		private readonly UserManager<IdentityUser> _userManager;

		public AuthController(SignInManager<IdentityUser> signInManager,
                              UserManager<IdentityUser> userManager)
		{
            _signInManager = signInManager;
            _userManager = userManager;

        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
		{
            return View(new LoginViewModel { ReturnUrl = returnUrl});
		}
        
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
		{
            // Check if the model is valid
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Username, loginViewModel.Password, false, false);

			if (result.Succeeded)
			{
                return Redirect(loginViewModel.ReturnUrl);
			}
			else if (result.IsLockedOut)
			{

			}

            return View();
		}

        [HttpGet]
        public IActionResult Register(string returnUrl)
        {
            return View(new RegisterViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel  registerViewModel)
        {
            if (!ModelState.IsValid)
                return View(registerViewModel);

            // Check if the model is valid
            var user = new IdentityUser(registerViewModel.Username);
            var result = await _userManager.CreateAsync(user, registerViewModel.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return Redirect(registerViewModel.ReturnUrl);
            }

            return View();
        }


    }
}
