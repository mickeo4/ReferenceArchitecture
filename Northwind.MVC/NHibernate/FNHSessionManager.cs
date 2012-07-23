﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Context;
using AdventureWorks.Domain;

namespace AdventureWorks.MVC.NHibernate
{
   public class FNHSessionManager<T> : IFNHSessionManager, IDisposable
   {
       private readonly ISessionFactory _sessionFactory;

       public ISessionFactory SessionFactory
       {
           get { return _sessionFactory; }
       }

       public ISession Session
       {
           get
           {
               if (!ManagedWebSessionContext.HasBind(HttpContext.Current, SessionFactory))
               {
                   ManagedWebSessionContext.Bind(HttpContext.Current, SessionFactory.OpenSession());
               }
               return _sessionFactory.GetCurrentSession();
           }
       }

       private readonly ITransaction _transaction;

       public FNHSessionManager()
       {
            String dbConnection = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            _sessionFactory = Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2008
                        .ConnectionString(dbConnection)
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Customer>())
                .CurrentSessionContext(typeof(ManagedWebSessionContext).FullName)
                .BuildSessionFactory();
            

            if (HttpContext.Current != null && HttpContext.Current.ApplicationInstance != null)
            {
                HttpContext.Current.ApplicationInstance.EndRequest += (sender, args) => CleanUp();
            }

            _transaction = Session.BeginTransaction();
        }


        /// <summary>
        /// Rollback the current transaction set.
        /// </summary>
        public void Rollback()
        {
            if (_transaction.IsActive)
                _transaction.Rollback();
        }

        /// <summary>
        /// Commit the current transaction set to the database.
        /// </summary>
        public void Commit()
        {
            if (_transaction.IsActive)
                _transaction.Commit();
        }

        /// <summary>
        /// Clean up the session.
        /// </summary>
        public void CleanUp()
        {
            CleanUp(HttpContext.Current, _sessionFactory);
        }

        /// <summary>
        /// Static function to clean up the session.
        /// </summary>
        /// <param name="context">The context to which the session has been bound.</param>
        /// <param name="sessionFactory">The session factory that contains the session.</param>
        public static void CleanUp(HttpContext context, ISessionFactory sessionFactory)
        {
            ISession session = ManagedWebSessionContext.Unbind(context, sessionFactory);

            if (session != null)
            {
                if (session.Transaction != null && session.Transaction.IsActive)
                {
                    session.Transaction.Rollback();
                }
                else if (context.Error == null && session.IsDirty())
                {
                    session.Flush();
                }
                session.Close();
            }
        }

        /// <summary>
        /// Dispose of the session factory.
        /// </summary>
        public void Dispose()
        {
            CleanUp();
            _sessionFactory.Dispose();
        }
   }
}