using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecibelSoftPackage.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        // GET: Employee
        public ActionResult EmployeePortal()
        {
            return View();
        }
    }
}