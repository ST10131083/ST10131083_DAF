using Microsoft.AspNetCore.Mvc;

namespace ST10131083_DAF.Controllers.Admin
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
