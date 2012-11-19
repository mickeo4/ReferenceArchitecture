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
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

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
            GridResult<IEnumerable<Customer>> result = customerService.Execute(page.GetValueOrDefault(0), pageSize.GetValueOrDefault(10));

            Guard.Against<ArgumentNullException>(result.Entity == null, "Result cannot be null when loading customers");

            var model = new CustomerViewModel();

            model.CustomerGridResult = result;

            return View("CustomerList", model);
        }

        public ActionResult GetNextCustomers([DataSourceRequest] DataSourceRequest request)
        {
            Guard.Against<ArgumentNullException>(request == null, "Grid request cannot be null when loading customers");

            GridResult<IEnumerable<Customer>> result = customerService.Execute(request.Page, request.PageSize);

            Guard.Against<ArgumentNullException>(result == null, "Result cannot be null when loading customers using AJAX");

            DataSourceResult dataSource = new DataSourceResult
            {
                Data = result.Entity,
                Total = result.TotalRecords
            };
            
            return Json(dataSource);
        }

        #endregion
    }
}
