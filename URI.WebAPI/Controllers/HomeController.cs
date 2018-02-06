using Microsoft.AspNetCore.Mvc;

namespace URI.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}