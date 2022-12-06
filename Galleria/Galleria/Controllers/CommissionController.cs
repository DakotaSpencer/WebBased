using Galleria.Data;
using Galleria.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Galleria.Controllers
{
    public class CommissionController : Controller
    {
        IDataAccessLayer dal;

        public CommissionController(IDataAccessLayer dal, CommissionDAL db)
        {
            this.dal = dal;

            if (dal.GetType() == typeof(CommissionDAL))
            {
                ((CommissionDAL)dal).db = db;
            }
        }


        [HttpGet]
        public IActionResult CommissionGallery()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("CommissionGallery", dal.GetCommissions);
            }
            else
            {
                return View("Login");
            }
        }
    }
}
