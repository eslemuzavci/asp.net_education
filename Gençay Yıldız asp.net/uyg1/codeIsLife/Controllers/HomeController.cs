using Microsoft.AspNetCore.Mvc;

namespace codeIsLife.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
