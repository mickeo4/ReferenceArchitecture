using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace AdventureWorks.CrossCutting.NHibernate
{
    public interface IQueryableRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T RetrieveById(int id);
        void Create(T entity);
        void Create(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
    }
}