using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using textrackMigration.Models;
using textrackMigration.Models.AccountViewModels;
using System.Collections.Generic;
namespace textrackMigration.Controllers
{
    public class ServiceController : Controller
    {
        public ServiceController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
                _userManager = userManager;
                _signInManager = signInManager;
        }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        [HttpPost] public async Task<JsonResult> SignIn(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(userName: model.Email, password: model.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded) return Json(new KeyValuePair<string, string>("response", "OK"));
            return Json(new KeyValuePair<string, string>("response", "FAILED"));
        }
    }
}