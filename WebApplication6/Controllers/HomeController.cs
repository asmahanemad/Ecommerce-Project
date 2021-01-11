using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;


namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        employeeContextEntites db = new employeeContextEntites();
        public ActionResult Index(string searching )
        {
           
            return View(db.emolyee.Where(x => x.empolyeeName.Contains(searching) || searching == null).ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}