using Microsoft.AspNetCore.Mvc;

namespace DotNetcore_projects_terorials.Controllers
{
    // Controllers are basically C# classes that inherit from " MIcrosoft.AspNetCore.Mvc.Controller.
    // Controller along with its action methods accepts incoming browser  requests, retrieves required model information and provides suitable response
    // it is recommended that class name of a controler ends with suffix " Controller"
    // In an ASP.NET CORE MVC application , a controller is responsible to:
    // Locate the appropriate method to call for an incomimg request.
    // validate the data of the incomimg request before invoking the requested method
    public class HomeController : Controller
    {


        // below is convention routing
        //public IActionResult Index()


        //{
        //    return View();
        //}

        // let me implement Attribute routes
        [Route("")]
        [Route("Home")]
        [Route("Home/index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Home/Details/{id}")]
        public int Details(int id)
        {
            return id;
        }

        // Routing = URL + HTTP METHODS

    }
}
