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
        public void Test_When_Home_Controller_Index_Action_Called_That_Splash_View_Result_Is_Not_Null()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result, "View result was null when expecting 'Index' result");
        }

        [TestMethod]
        public void Test_When_Home_Controller_Index_Action_Called_That_Splash_View_Returned()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual(result.ViewName, "Index", "View name was not equal to 'Index'");
        }

        
    }
}
