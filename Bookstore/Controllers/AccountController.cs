﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookstore.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            userManager = um;
            signInManager = sim;
        }

        [HttpGet]
        public IActionResult Login(string returnURL)
        {
            return View(new LoginModel { ReturnUrl = returnURL });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginModel.Username);

                if (user != null)
                {
                    await signInManager.SignOutAsync();

                    if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect(loginModel.ReturnUrl ?? "/Admin");
                    }
                }
            }

            ModelState.AddModelError("", "Invalid Username or Password.");
            return View(loginModel);
        }

        public async Task<RedirectResult> Logout (string returnURL = "/")
        {
            await signInManager.SignOutAsync();

            return Redirect(returnURL);
        }
    }
}
