<<<<<<< HEAD
﻿using Galleria.Interfaces;
=======
﻿using Galleria.Data;
using Galleria.Interfaces;
using Galleria.Models;
>>>>>>> fe907467e320ee454cd691090457d7fe52299370
using Microsoft.AspNetCore.Mvc;

namespace Galleria.Controllers
{
    public class ProfileController : Controller
    {
<<<<<<< HEAD
     

    
=======

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
            dal.AddUser(user);
            return View("Index");
        }

>>>>>>> fe907467e320ee454cd691090457d7fe52299370
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
