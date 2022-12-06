using Microsoft.AspNetCore.Mvc;

namespace Galleria.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _PricingInformation()
        {
            return View();
        }

        public IActionResult _ContactInformation()
        {
            return View();
        }

        public IActionResult _AboutMePartial()
        {
            return View();
        }

        public IActionResult _Commissions()
        {
            return View();
        }

        public IActionResult CreateCommission()
        {
            return View();
        }

        public IActionResult EditCommission()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }
    }
        
}
