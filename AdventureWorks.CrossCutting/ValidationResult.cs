using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.CrossCutting
{
    /// <summary>
    /// Simple class to handle any results returned from an operation
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public class Result<T>
    {
        public bool Success { get; set; }
        public String ErrorMessage { get; set; }
        public T Entity { get; set; }
    }
}
