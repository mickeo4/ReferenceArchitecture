using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdventureWorks.Domain;
using AdventureWorks.CrossCutting;

namespace AdventureWorks.MVC.Models.Customer
{
    public class CustomerViewModel : CustomerEditModel
    {
        public GridResult<IEnumerable<AdventureWorks.Domain.Customer>> CustomerGridResult { get; set; }
    }
}