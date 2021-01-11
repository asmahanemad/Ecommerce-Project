using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;
using System.Data.Entity.Validation;

namespace WebApplication6.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(Registration userModel)
        {
            using (employeeContextEntites db = new employeeContextEntites())
            {
                if (ModelState.IsValid) {
                    try
                    {
                        db.Registration.Add(userModel);
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException e)
                    {
                        Console.WriteLine(e);
                    }
                    return RedirectToAction("Index", "Login");
                }
                else {
                    return View(userModel);
                }

            }
        }
          
                   
    }
}
