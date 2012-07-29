using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdventureWorks.CrossCutting;
using AdventureWorks.MVC.NHibernate;
using AdventureWorks.Domain;
using AdventureWorks.MVC.Filters;
using AdventureWorks.ApplicationServices.GetCustomers;

namespace AdventureWorks.MVC.Controllers
{
    public class CustomerController : Controller
    {
        #region Variables

        private IGetCustomersByPage customerService;

        #endregion

        #region Constructor

        public CustomerController(IGetCustomersByPage custService)
        {
            customerService = custService;
        }

        #endregion

        #region Actions

        [HttpGet]
        [ModelStateToTempData]
        public ActionResult Index(int? page, int? pageSize)
        {
            Result<IEnumerable<Customer>> result = customerService.Execute(page.GetValueOrDefault(0), pageSize.GetValueOrDefault(10));

            return View();
        }

        #endregion
    }
}
