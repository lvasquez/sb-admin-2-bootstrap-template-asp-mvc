using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sb_admin_2.Web.Controllers;
using System.Web.Mvc;
using sb_admin_2.Web.Models;

namespace sb_admin_2.Web.Tests.Controllers
{
    /// <summary>
    /// Summary description for NavbarControllerTest
    /// </summary>
    [TestClass]
    public class NavbarControllerTest
    {
      
        [TestMethod]
        public void Navbar_Items_Return_NotNull()
        {

            var _controller = new NavbarController();

            var result = _controller.Index();
            var rresult = (PartialViewResult)result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(PartialViewResult));
            Assert.AreEqual(rresult.ViewName, "_Navbar");
            Assert.IsInstanceOfType(rresult.Model, typeof(IEnumerable<Navbar>));
        }
    }
}
