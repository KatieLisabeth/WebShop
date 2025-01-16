using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    public class WebShopController : Controller
    {
        // GET: WebShopController
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registreer()
        {
            return View();
        }

        public IActionResult WinkelMandje()
        {
            return View();
        }
    }
}
