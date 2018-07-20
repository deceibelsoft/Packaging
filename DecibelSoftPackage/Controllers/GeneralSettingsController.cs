using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecibelSoftPackage.Controllers
{
    public class GeneralSettingsController : Controller
    {
        // GET: GeneralSettings
        public ActionResult Index()
        {
            return View();
        }
        // GET: GeneralSettings
        public ActionResult EmployerSettings()
        {
            return View();
        }

    }
}