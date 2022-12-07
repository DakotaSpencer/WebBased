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

        public CommissionController(IDataAccessLayer dal, GalleriaContext db)
        {
            this.dal = dal;

            if (dal.GetType() == typeof(CommissionDAL))
            {
                ((CommissionDAL)dal).db = db;
            }
        }


        public IActionResult CommissionGallery()
        {
            return View("CommissionGallery",dal.GetCommissions());
        }
    }
}
