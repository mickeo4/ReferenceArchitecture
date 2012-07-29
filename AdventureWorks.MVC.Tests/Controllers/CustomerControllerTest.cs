using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using AdventureWorks.MVC.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorks.MVC;
using AdventureWorks.MVC.Models.Customer;
using AdventureWorks.ApplicationServices.GetCustomers;
using Moq;

namespace AdventureWorks.Tests.Controllers
{
    [TestClass]
    public class CustomerControllerTest
    {
        [TestMethod]
        public void Test_When_Customer_Controller_Index_Action_Called_That_Customer_View_Result_Is_Not_Null()
        {
            // Arrange
            var mock = new Mock<IGetCustomersByPage>();
            IGetCustomersByPage getCustomersByPage = mock.Object;

            CustomerController controller = new CustomerController(getCustomersByPage);

            // Act
            ViewResult result = controller.Index(null, null) as ViewResult;

            // Assert
            Assert.IsNotNull(result, "View result was null when expecting 'Index' result");
        }

        [TestMethod]
        public void Test_When_Customer_Controller_Index_Action_Called_That_Customer_View_Returned()
        {
            // Arrange
            var mock = new Mock<IGetCustomersByPage>();
            IGetCustomersByPage getCustomersByPage = mock.Object;

            CustomerController controller = new CustomerController(getCustomersByPage);

            // Act
            ViewResult result = controller.Index(null, null) as ViewResult;

            // Assert
            Assert.AreEqual(result.ViewName, "Index", "View name was not equal to 'Index'");
        }

        [TestMethod]
        public void Test_When_Customer_Controller_Index_Action_Called_That_First_Ten_Customers_Returned()
        {
            // Arrange
            var mock = new Mock<IGetCustomersByPage>();
            IGetCustomersByPage getCustomersByPage = mock.Object;

            CustomerController controller = new CustomerController(getCustomersByPage);

            // Act
            ViewResult result = controller.Index(1, 10) as ViewResult;

            // Assert
            Assert.AreEqual(((CustomerViewModel)result.Model).Customers.Count(), 10, "View name was not equal to 'Index'");
        }
    }
}
