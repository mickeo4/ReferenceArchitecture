using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.CrossCutting
{
    /// <summary>
    /// Simple class to handle any results returned as a collection for a grid
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public class GridResult<T>
    {
        public bool Success { get; set; }
        public String ErrorMessage { get; set; }
        public T Entity { get; set; }
        public int TotalRecords { get; set; }
    }
}
