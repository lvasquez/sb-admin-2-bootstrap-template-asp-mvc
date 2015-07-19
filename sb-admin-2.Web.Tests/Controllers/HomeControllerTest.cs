using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sb_admin_2.Web;
using sb_admin_2.Web.Controllers;

namespace sb_admin_2.Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        private HomeController _controller;
        
        [TestInitialize]
        public void Setup()
        {
            _controller = new HomeController();
        }


        [TestMethod]
        public void Index()
        {

            // Act
            ViewResult result = _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void FlotCharts()
        {

            ViewResult result = _controller.FlotCharts() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "FlotCharts");
        }

        [TestMethod]
        public void MorrisCharts()
        {

            ViewResult result = _controller.MorrisCharts() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "MorrisCharts");
        }

        [TestMethod]
        public void Tables()
        {

            ViewResult result = _controller.Tables() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Tables");
        }

        [TestMethod]
        public void Forms()
        {

            ViewResult result = _controller.Forms() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Forms");
        }

        [TestMethod]
        public void Panels()
        {

            ViewResult result = _controller.Panels() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Panels");
        }

        [TestMethod]
        public void Buttons()
        {

            ViewResult result = _controller.Buttons() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Buttons");
        }

        [TestMethod]
        public void Notifications()
        {

            ViewResult result = _controller.Notifications() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Notifications");
        }

        [TestMethod]
        public void Typography()
        {

            ViewResult result = _controller.Typography() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Typography");
        }

        [TestMethod]
        public void Icons()
        {

            ViewResult result = _controller.Icons() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Icons");
        }

        [TestMethod]
        public void Grid()
        {

            ViewResult result = _controller.Grid() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Grid");
        }

        [TestMethod]
        public void Blank()
        {

            ViewResult result = _controller.Blank() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Blank");
        }

        [TestMethod]
        public void Login()
        {

            ViewResult result = _controller.Login() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(result.ViewName, "Login");
        }

      
    }
}
