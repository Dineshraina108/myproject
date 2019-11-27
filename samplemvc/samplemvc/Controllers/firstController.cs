using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace samplemvc.Controllers
{
    public class firstController : Controller
    {
        //
        // GET: /first/
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();

        }
        public ActionResult login()
        {
            return View();
        }
	}
}