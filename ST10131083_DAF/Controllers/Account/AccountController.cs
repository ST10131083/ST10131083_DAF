using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ST10131083_DAF.Data;
using ST10131083_DAF.Models.Account;
using ST10131083_DAF.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ST10131083_DAF.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly ApplicationContext context;

        public AccountController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginSignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = context.Users.Where(e => e.Email == model.Email).SingleOrDefault();
                if (data != null)
                {
                    bool isValid = (data.Email == model.Email && data.Password == model.Password);
                    if (isValid)
                    {
                        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.Email) },
                            CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        HttpContext.Session.SetString("Email", model.Email);
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                        TempData["errorPassword"] = "Invalid Password!";
                        return View(model);
                    }

                }
                else
                {
                    TempData["errorEmail"] = "Email does not exist!";
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = new User()
                {
                    Email = model.Email,
                    Password = model.Password,
                    isActive = model.isActive
                };

                context.Users.Add(data);
                context.SaveChanges();
                TempData["successMessage"] = "Registration Succesful, Please enter your credentials to login!";
                return RedirectToAction("Login");
            }
            else
            {
                TempData["errorMessage"] = "Empty form can't be submited!";
                return View(model);
            }
            
        }
    }
}
