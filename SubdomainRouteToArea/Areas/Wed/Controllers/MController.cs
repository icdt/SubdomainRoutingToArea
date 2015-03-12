using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubdomainRouteToArea.Areas.Wed.Controllers
{
    public class MController : Controller
    {
        // GET: Wed/M
        public ActionResult Index(string subdomain)
        {
            ViewBag.SubDomain = subdomain;
            return View();
        }

        public ActionResult About(string subdomain) 
        {
            ViewBag.SubDomain = subdomain;
            return View();
        }
    }
}