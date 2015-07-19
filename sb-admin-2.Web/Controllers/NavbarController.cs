using sb_admin_2.Web.Domain;
using sb_admin_2.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sb_admin_2.Web.Controllers
{
    public class NavbarController : Controller
    {
        // GET: Navbar
        public ActionResult Index()
        {
            var data = new Data();            
            return PartialView("_Navbar", data.navbarItems().ToList());
        }
    }
}