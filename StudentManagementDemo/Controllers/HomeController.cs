using StudentManagementDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        //public ActionResult DOB()
        //{
        //    ViewData["Age"] = "Enter Your DOB!!!";
        //    return View();
        //}
        //// [HttpPost]
        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult DOB(DOBModel dob)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View("DOB", dob);
        //    }
        //    else
        //    {
        //        DateTime old = Convert.ToDateTime(dob.date1);
        //        if (DateTime.Now > old)
        //        {
        //            int age = DateTime.Now.AddYears(-old.Year).Year;
        //            ViewData["Age"] = age;
        //            return View("DOB", dob);
        //        }
        //        else
        //        {
        //            ViewData["Age"] = "Your Dob is older that current time!!!";
        //            return View("DOB", dob);
        //        }
        //    }

        //}
    }
}