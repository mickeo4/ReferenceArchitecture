using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorks.CrossCutting;
using AdventureWorks.Domain;

namespace AdventureWorks.ApplicationServices.GetCustomers
{
    public interface IGetCustomersByPage
    {
        Result<IEnumerable<Customer>> Execute(int page, int pageSize);
    }
}
