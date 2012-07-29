using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdventureWorks.Domain;

namespace AdventureWorks.MVC.Models.Customer
{
    public class CustomerViewModel : CustomerEditModel
    {
        public IEnumerable<AdventureWorks.Domain.Customer> Customers { get; set; }
    }
}