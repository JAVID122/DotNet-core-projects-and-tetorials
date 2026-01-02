using Microsoft.AspNetCore.Mvc;

namespace DotNetcore_projects_terorials.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
