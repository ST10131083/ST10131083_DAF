using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ST10131083_DAF.Data;
using ST10131083_DAF.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10131083_DAF.Controllers.Dashboard
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ApplicationContext context;

        public DashboardController(ApplicationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        public IActionResult Donate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Donate(Donation model)
        {
            if (ModelState.IsValid)
            {
                var data = new Donation()
                {
                    Amount = model.Amount,
                    Email = model.Email,
                    Fname = model.Fname,
                    Lname = model.Lname,
                    Mobile = model.Mobile,
                    Date = model.Date,
                    isPrivate = model.isPrivate,
                    Userid = model.Userid


                };

                context.Donations.Add(data);              
                context.SaveChanges();
                TempData["successMessage"] = "Donation Successful! Thank you for your donation! You are a STAR..";
                return RedirectToAction("Donate");
            }
            else
            {
                TempData["errorMessage"] = "Empty form can't be submited!";
                return View(model);
            }
        }


    }
}
