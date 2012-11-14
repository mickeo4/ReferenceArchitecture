using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using AdventureWorks.MVC.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorks.MVC;

namespace AdventureWorks.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Test_When_Home_Controller_Index_Action_Called_That_Index_View_Returned()
        {
            // Arrange
            const string expectedViewName = "Index";
            var homeController = new HomeController();

            // Act
            var result = homeController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result, "Should have returned a ViewResult");

            Assert.AreEqual(expectedViewName, result.ViewName, "View name should have been {0}", expectedViewName);
        }

        [TestMethod]
        public void Test_When_Home_Controller_About_Action_Called_That_About_View_Returned()
        {
            // Arrange
            const string expectedViewName = "About";
            var homeController = new HomeController();

            // Act
            var result = homeController.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result, "Should have returned a ViewResult");

            Assert.AreEqual(expectedViewName, result.ViewName, "View name should have been {0}", expectedViewName);
        }

        [TestMethod]
        public void Test_When_Home_Controller_Contact_Action_Called_That_Contact_View_Returned()
        {
            // Arrange
            const string expectedViewName = "Contact";
            var homeController = new HomeController();

            // Act
            var result = homeController.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result, "Should have returned a ViewResult");

            Assert.AreEqual(expectedViewName, result.ViewName, "View name should have been {0}", expectedViewName);
        }
    }
}
