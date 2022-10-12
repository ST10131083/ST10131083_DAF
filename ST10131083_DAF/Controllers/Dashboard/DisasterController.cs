using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        //[HttpGet]
        public IActionResult Create()
        {
            //var items = context.Categories.ToList();
            ViewBag.CategoryId = new SelectList(context.Categories, "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Disaster model)
        {
            if (ModelState.IsValid)
            {
                var data = new Disaster()
                {
                    DisasterName = model.DisasterName,
                    DisasterType = model.DisasterType,
                    Location = model.Location,
                    Description = model.Description,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    AmountAllocation = model.AmountAllocation,
                    Categoryid = model.Categoryid                    
                };

                context.Disasters.Add(data);
                context.SaveChanges();
                TempData["errorMessage"] = "Disaster Captured Saved!";
                return RedirectToAction("Index", "Disaster");
            }
            else
            {
                TempData["errorMessage"] = "Empty field can't be submited!";
                
            }
            ViewBag.CategoryId = new SelectList(context.Categories, "CategoryId", "CategoryName", model.Categoryid);
            return View(model);
        }
    }
}
