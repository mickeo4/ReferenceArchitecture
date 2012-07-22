using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.MVC.NHibernate
{
    public interface IFNHRepository<T>
    {
        void Create(T objectToAdd);
        T RetrieveById(int id);
        void Update(T objectToUpdate);
        void Delete(T objectToDelete);
    }
}