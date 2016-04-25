using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLab.Controllers
{
    public class SupermanController : Controller
    {
        public ActionResult DoGood()
        {
            return View();
        }
    }
}