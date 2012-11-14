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

        private Mock<IGetCustomersByPage> getCustomersByPage;
        private CrossCutting.Result<IEnumerable<Domain.Customer>> serviceResult;
        private List<Domain.Customer> customers;

        [TestInitialize]
        public void TestInitialize()
        {
            // Arrange
            getCustomersByPage = new Mock<IGetCustomersByPage>(); // Setup GetCustomersByPage application service

            serviceResult = new CrossCutting.Result<IEnumerable<Domain.Customer>>(); // Setup dummy result
            customers = new List<Domain.Customer>();
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test1", LastName = "test2", EmailAddress = "test3" });
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test2", LastName = "test3", EmailAddress = "test4" });
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test3", LastName = "test4", EmailAddress = "test5" });
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test4", LastName = "test5", EmailAddress = "test6" });
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test5", LastName = "test6", EmailAddress = "test7" });
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test6", LastName = "test7", EmailAddress = "test8" });
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test7", LastName = "test8", EmailAddress = "test9" });
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test8", LastName = "test9", EmailAddress = "test10" });
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test9", LastName = "test10", EmailAddress = "test11" });
            customers.Add(new Domain.Customer() { Title = "Mr", FirstName = "test10", LastName = "test11", EmailAddress = "test12" });
            serviceResult.Entity = customers;
            serviceResult.Success = true;

            getCustomersByPage.Setup(foo => foo.Execute(1, 10)).Returns(serviceResult); // Setup result action
        }

        [TestMethod]
        public void Test_When_Customer_Controller_Index_Action_Called_That_Customer_View_Returned()
        {
            // Arrange
            const string expectedViewName = "CustomerList";
            var customerController = new CustomerController(getCustomersByPage.Object); // Setup controller with service injection

            // Act
            var result = customerController.Index(1, 10) as ViewResult;

            // Assert
            Assert.IsNotNull(result, "Should have returned a ViewResult");

            Assert.AreEqual(expectedViewName, result.ViewName, "View name should have been {0}", expectedViewName);
        }

        [TestMethod]
        public void Test_When_Customer_Controller_Index_Action_Called_That_First_Ten_Customers_Returned()
        {
            // Arrange
            var mock = new Mock<IGetCustomersByPage>();
            IGetCustomersByPage getCustomersByPage = mock.Object;

            var customerController = new CustomerController(getCustomersByPage);

            // Act
            ViewResult result = customerController.Index(1, 10) as ViewResult;

            // Assert
            Assert.AreEqual(((CustomerViewModel)result.Model).Customers.Count(), 10, "10 customers were not returned");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            
        }
    }
}
