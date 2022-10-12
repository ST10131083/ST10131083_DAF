using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ST10131083_DAF.Data;
using ST10131083_DAF.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10131083_DAF.Controllers.Dashboard
{
    public class DisasterController : Controller
    {
        private readonly ApplicationContext context;

        public DisasterController(ApplicationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var disasters = context.Disasters.Include(d => d.Category);
            return View(disasters.ToList()); 
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Disaster model)
        {
            if (ModelState.IsValid)
            {
                var data = new Disaster()
                {
                    DisasterName = model.DisasterName,
                    DisasterType = model.DisasterType,
                    Location = model.Location,

                };

                context.Categories.Add(data);
                context.SaveChanges();
                TempData["errorMessage"] = "Category Saved!";
                return RedirectToAction("Index", "Categories");
            }
            else
            {
                TempData["errorMessage"] = "Empty field can't be submited!";
                return View(model);
            }
        }
    }
}
