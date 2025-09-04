using System.Diagnostics;
using BaiTap.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var latestProducts = new List<string>
            {
                "Nồi cơm điện Nagakawa NAG0102",
                "Nồi cơm điện Nagakawa NAG0102",
                "Nồi cơm điện Nagakawa NAG0102",
                "Nồi cơm điện cao tần nagakawa ng13"
            };

            return View(latestProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
