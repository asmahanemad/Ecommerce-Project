using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using System.Data;

namespace WebApplication6.Controllers
{
    public class LoginController : Controller
    {
        employeeContextEntites db = new employeeContextEntites();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authein(WebApplication6.Models.Login loginModel)
        {
            var userDetails = db.Login.Where(x => x.UserName == loginModel.UserName && x.Password == loginModel.Password).FirstOrDefault();
            if (userDetails == null)
            {
                loginModel.Error = "wrong username or password";
                return View("Index",loginModel);
            }
            else
            {
                Session["UserID"] = userDetails.UserID;
                Session["UserName"] = userDetails.UserName;
                return RedirectToAction("Create", "empolyee");
            }


        }
        public ActionResult LogOut()
        {
            int userid = (int)Session["UserID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
       
    }
}

