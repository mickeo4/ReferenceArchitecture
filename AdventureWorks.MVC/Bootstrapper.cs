using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using AdventureWorks.MVC.NHibernate;
using AdventureWorks.Domain;
using AdventureWorks.MVC.Controllers;
using AdventureWorks.CrossCutting.NHibernate;
using AdventureWorks.Repository.NHibernate;
using AdventureWorks.ApplicationServices.GetCustomers;

namespace AdventureWorks.MVC
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            #region Architecture Registrations

            container.RegisterType<ISessionManager, SessionManager>();

            #endregion

            #region Application Services Registrations

            container.RegisterType<IGetCustomersByPage, GetCustomersByPage>();

            #endregion

            #region Repository Registrations

            container.RegisterType<IQueryableRepository<Customer>, QueryableRepository<Customer>>();

            #endregion

            return container;
        }
    }
}