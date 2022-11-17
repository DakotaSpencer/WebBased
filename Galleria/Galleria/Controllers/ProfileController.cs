using Microsoft.AspNetCore.Mvc;

namespace Galleria.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
