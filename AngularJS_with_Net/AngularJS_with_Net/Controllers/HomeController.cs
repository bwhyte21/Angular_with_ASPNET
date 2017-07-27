using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// bring in angular models
using AngularJS_with_Net.Models;
namespace AngularJS_with_Net.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // set employee name
            Employee emp = new Employee()
            {
                FirstName = "John",
                LastName = "Doe"
            };
            return View(emp);
        }

        public ActionResult UpdateData(string angStr)
        {
            // method to get from ui, appending string to it
            var updatedData = angStr + "--update successful --";
            // assigning string, manipulating data sent in method
            var response = new Employee() { FirstName = "Bryan", LastName = "Whyte", Extra = updatedData };
            // packing up and sending off as json back to angular
            return Json(response, JsonRequestBehavior.AllowGet);
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