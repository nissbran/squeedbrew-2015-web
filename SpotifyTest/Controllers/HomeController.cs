using Microsoft.AspNet.Mvc;

namespace SpotifyTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
