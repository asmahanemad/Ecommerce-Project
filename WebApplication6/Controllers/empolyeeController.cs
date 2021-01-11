using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class empolyeeController : Controller
    {
        // GET: empolyee
        employeeContextEntites db = new employeeContextEntites();

        public ActionResult Index()
        {
            return View(db.emolyee.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(emolyee Employee)
        {
            if (ModelState.IsValid)
            {
                db.emolyee.Add(Employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Employee);
        }
        public ActionResult Deatils(int? id)
        { emolyee Emp = db.emolyee.Find(id);

            if (id == null) {
                return new  HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            if (Emp == null) {
                return HttpNotFound();
            }
            else
            {
                return View(Emp);
            }
        }
        public ActionResult Edit(int id = 0)
        {

            emolyee emp = db.emolyee.Find(id);
            if(emp == null)
            {
                return HttpNotFound();
            }
            

            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(emolyee Emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Emp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Emp);
        }
        public ActionResult Delete(int id)
        { 
            try
            {
                 emolyee Emp = db.emolyee.Where(x => x.empolyeeId == id).FirstOrDefault() ;
                    db.emolyee.Remove(Emp);
                    db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
           
        }

    }
}