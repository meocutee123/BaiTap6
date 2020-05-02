using BaiTap6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap6.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLNVEntities db = new QLNVEntities();
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
        public ActionResult Search(string search, string option)
        {
            if (option == "LastName")
            {
                return View(db.Employees.Where(x => x.employeeLastName.Contains(search) || search == null).ToList());
            }
            else if (option == "FirstName")
            {
                return View(db.Employees.Where(x => x.employeeFirstName.Contains(search) || search == null).ToList());
            }
            else
            {
                return View(db.Employees.Where(x => x.employeeAddress.Contains(search) || search == null).ToList());
            }

        }
    }
}