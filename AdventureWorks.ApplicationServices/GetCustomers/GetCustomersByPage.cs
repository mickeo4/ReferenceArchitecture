using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorks.CrossCutting;
using AdventureWorks.Domain;
using AdventureWorks.CrossCutting.NHibernate;

namespace AdventureWorks.ApplicationServices.GetCustomers
{
    public class GetCustomersByPage : IGetCustomersByPage
    {
        #region Variables

        private IQueryableRepository<Customer> _customerQueryableRepository;

        #endregion

        #region Cosntrucors

        public GetCustomersByPage(IQueryableRepository<Customer> custRepo)
        {
            _customerQueryableRepository = custRepo;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Execute method for GetCustomerByPage which gets collection of customer entities
        /// </summary>
        /// <param name="page">Current page</param>
        /// <param name="pageSize">Size of page</param>
        /// <returns>IEnumerable of Customers</returns>
        public Result<IEnumerable<Customer>> Execute(int page, int pageSize)
        {
            Guard.Against<ArgumentOutOfRangeException>(page < 0, "Parameter 'page' is out of range");
            Guard.Against<ArgumentOutOfRangeException>(pageSize < 0, "Parameter 'pageSize' is out of range");

            // Get page of customer entities
            IEnumerable<Customer> customers = _customerQueryableRepository.GetAll().Skip(page - 1 *pageSize).Take(pageSize).ToList();

            // Assume that we should have at least one customer
            Guard.Against<NullReferenceException>(customers == null, "Customers cannot be null");

            Result<IEnumerable<Customer>> result = new Result<IEnumerable<Customer>>(){Entity = customers, ErrorMessage = null, Success = true};

            return result;
        }

        #endregion
    }
}
