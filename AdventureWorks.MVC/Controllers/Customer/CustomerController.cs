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
using AdventureWorks.MVC.Models.Customer;

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

        /// <summary>
        /// Entry point for customer controller
        /// </summary>
        /// <param name="page">Current page of results</param>
        /// <param name="pageSize">Page size of results</param>
        /// <returns>Index view result</returns>
        [HttpGet]
        [ModelStateToTempData]
        public ActionResult Index(int? page, int? pageSize)
        {
            return View("CustomerList");
        }

        [HttpGet]
        [ModelStateToTempData]
        public JsonResult GetCustomers(int? page, int? pageSize)
        {
            Result<IEnumerable<Customer>> result = customerService.Execute(page.GetValueOrDefault(0), pageSize.GetValueOrDefault(10));

            return Json(new { data = result.Entity, total = result.Entity.Count() }, JsonRequestBehavior.AllowGet);

            //Guard.Against<ArgumentNullException>(result.Entity == null, "Result cannot be null when loading customers");

            //var model = new CustomerViewModel();

            //model.Customers = result.Entity;

            //return View("CustomerList", model);
        }

        #endregion
    }
}
