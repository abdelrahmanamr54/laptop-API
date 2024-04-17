using Api_Laptop_Task.DTO;
using Api_Laptop_Task.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api_Laptop_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        UserManager<ApplicationUser> userManager;
        SignInManager<ApplicationUser> signIn;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signIn)
        {
            this.userManager = userManager;
            this.signIn = signIn;
        }





        [HttpPost]
        [Route("api/Account/Registration")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(ApplicationUserDTO userVM)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser() { UserName = userVM.Name, Email = userVM.Email, Address = userVM.Address, PasswordHash = userVM.Password };

                var result = await userManager.CreateAsync(user, userVM.Password);
                if (result.Succeeded)
                {
                    await signIn.SignInAsync(user, false);
                   
                }
                return Ok();
            }

            return Ok();
        }
        [HttpPost]
        [Route("api/Account/Login")]
        public async Task<IActionResult> Login(UserLoginDTO userVM)
        {
            if (ModelState.IsValid)
            {
                var result = await userManager.FindByNameAsync(userVM.UserName);
                if (result != null)
                {
                    bool check = await userManager.CheckPasswordAsync(result, userVM.Password);

                    if (check)
                    {
                        await signIn.SignInAsync(result, userVM.RememberMe);
                        return Ok();
                    }
                  //  ModelState.AddModelError("invalidpw", "invalidpassword");
                    return Unauthorized("Invalid  password");

                }
                else
                {
                    return Unauthorized("Invalid UserName");
                }

            }
            return Ok(userVM);

        }
    }
}
