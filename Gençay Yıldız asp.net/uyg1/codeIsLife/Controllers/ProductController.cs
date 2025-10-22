using Microsoft.AspNetCore.Mvc;

namespace codeIsLife.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
