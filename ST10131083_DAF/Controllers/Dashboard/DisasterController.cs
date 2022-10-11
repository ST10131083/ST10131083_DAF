using Microsoft.AspNetCore.Mvc;
using ST10131083_DAF.Data;
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
            var result = context.Disasters.ToList();
            return View();
        }
        
        public IActionResult Create()
        {            
            return View();
        }
    }
}
