using Microsoft.AspNetCore.Mvc;
using ST10131083_DAF.Data;
using ST10131083_DAF.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10131083_DAF.Controllers.Dashboard
{
    
    public class CategoriesController : Controller
    {
        private readonly ApplicationContext context;

        public CategoriesController(ApplicationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var result = context.Categories.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                var data = new Category()
                {
                    CategoryName = model.CategoryName                
                };

                context.Categories.Add(data);
                context.SaveChanges();              
                return RedirectToAction("Index");
            }
            else
            {
                TempData["errorMessage"] = "Empty field can't be submited!";
                return View(model);
            }
           
        }
    }
}
