using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdventureWorks.CrossCutting;
using NHibernate;

namespace AdventureWorks.CrossCutting.NHibernate
{
    public interface ISessionManager
    {
        ISession Session { get; }

        void CleanUp();
        void Rollback();
        void Commit();
    }
}