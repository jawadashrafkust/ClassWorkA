using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassWork2.Models;

namespace ClassWork2.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            

            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "Teacher")]
        public ActionResult MyAction()
        {
            MyModel model = new MyModel();

            model.RollNo = "CS1";
            model.Name = "Some Name";
            model.Address = "Some Address Some Address Some Address " +
                            "Some Address Some Address Some Address Some Address ";
            model.Marks = 60;

            return View(model);
        }
    }
}