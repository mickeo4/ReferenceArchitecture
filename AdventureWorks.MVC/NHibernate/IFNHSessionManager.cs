using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace AdventureWorks.MVC.NHibernate
{
    public interface IFNHSessionManager
    {
        ISession Session { get; }

        void CleanUp();
        void Rollback();
        void Commit();
    }
}