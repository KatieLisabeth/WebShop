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
            ViewData["Title"] = "Registreer";
            return View();
        }

        public IActionResult WinkelMandje()
        {
            ViewData["Title"] = "Uw WinkelMandje is here";
            return View();
        }
    }
}
