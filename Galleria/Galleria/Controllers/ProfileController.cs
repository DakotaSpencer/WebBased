using Galleria.Data;
using Galleria.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Galleria.Controllers
{
    public class ProfileController : Controller
    {

        IDataAccessLayer dal;

        public ProfileController(IDataAccessLayer dal, GalleriaContext db)
        {
            this.dal = dal;

            if (dal.GetType() == typeof(CommissionDAL))
            {
                ((CommissionDAL)dal).db = db;
            }
        }

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

    }
}
