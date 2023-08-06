using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    [Controller]
    public class HomeController : Controller
    {
        [Route("/")]
        public string Index()
        {
            return "Hello";
        }
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
    }
}
