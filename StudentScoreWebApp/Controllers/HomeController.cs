using StudentScoreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentScoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentsList()
        {
            var students = db.Students.OrderBy(s => s.LastName).ToList();
            return View(students);
        }
        

        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(Student student)
        {
            db.Students.Add(student);
            db.Students.OrderBy(p => p.LastName);
            db.SaveChanges();
            return RedirectToAction("StudentsList");
        }

        public ActionResult TopFive()
        {
            return View();
        }

        public ActionResult LowFive()
        {
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}