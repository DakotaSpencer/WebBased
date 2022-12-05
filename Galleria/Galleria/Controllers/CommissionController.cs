using Galleria.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Galleria.Controllers
{
    public class CommissionController : Controller
    {
        IDataAccessLayer dal;

        public CommissionController(IDataAccessLayer dal)
        {
            this.dal = dal;
        }

        public IActionResult PersonalCommissionGallery()
        {
            return View("");
        }
    }
}
