using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using NHibernate.Linq;
using AdventureWorks.CrossCutting.NHibernate;

namespace AdventureWorks.Repository.NHibernate
{
    public class QueryableRepository<T> : IQueryableRepository<T>
    {
        public readonly ISessionManager _sessionManager;

        public QueryableRepository(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        /// <summary>
        /// Retrieve all object instances from database as IQueryable
        /// </summary>
        /// <returns>IQueryable T</returns>
        public IQueryable<T> GetAll()
        {
            return _sessionManager.Session.Query<T>();
        }
        
        /// <summary>
        /// Retrieve all object instances from database as IQueryable that satisfy predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        /// <summary>
        /// Retrieve an object instance from the database by id.
        /// </summary>
        /// <param name="id">Id of the object to retrieve.</param>
        /// <returns>The object instance to use in the application.</returns>
        public T RetrieveById(int id)
        {
            return _sessionManager.Session.Get<T>(id);
        }

        /// <summary>
        /// Update an object in the database.
        /// </summary>
        /// <param name="entity">Object instance containing the information to change in the database.</param>
        public void Update(T entity)
        {
            _sessionManager.Session.Update(entity);
            _sessionManager.Commit();
        }

        /// <summary>
        /// Create an object in the database.
        /// </summary>
        /// <param name="entity">Object instance containing the information to add to the database.</param>
        public void Create(T entity)
        {
            _sessionManager.Session.Save(entity);
            _sessionManager.Commit();
        }

        /// <summary>
        /// Create a number of objects in database
        /// </summary>
        /// <param name="entities">IEnumerable of entities</param>
        public void Create(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                _sessionManager.Session.Save(entity);
            }
            
            _sessionManager.Commit();
        }

        /// <summary>
        /// Delete an object from the database.
        /// </summary>
        /// <param name="entity">Object instance containing the information to delete from the database.</param>
        public void Delete(T entity)
        {
            _sessionManager.Session.Delete(entity);
            _sessionManager.Commit();
        }

        /// <summary>
        /// Delete number of objects in database
        /// </summary>
        /// <param name="entities">IEnumerable of entities</param>
        public void Delete(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                _sessionManager.Session.Delete(entity);
            }

            _sessionManager.Commit();
        }
    }
}