using Microsoft.AspNetCore.Mvc;

namespace DotNetcore_projects_terorials.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
