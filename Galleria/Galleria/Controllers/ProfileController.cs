using Galleria.Data;
using Galleria.Interfaces;
using Galleria.Models;
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

        [HttpPost]
        public IActionResult AddUser()
        {
            Users user;
            int id = dal.GetUsers().Count() + 1;
            user = new Users(id, Request.Form["FirstName"], Request.Form["LastName"], Request.Form["Username"],
                Request.Form["Email"], Request.Form["Password"], "");
            return View("_LoginPartial");
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
