using Microsoft.AspNetCore.Mvc;

namespace TaskMvcPronia.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShopDefault()
        {
            return View();
        }

        public IActionResult SingleProductVariable()
        {
            return View();
        }
    }
}
