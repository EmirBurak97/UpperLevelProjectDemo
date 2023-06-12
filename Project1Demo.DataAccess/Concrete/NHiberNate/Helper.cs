using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg.Loquacious;
using NHibernate.Dialect;
using Project1Demo.Core.DataAccess.NHiberNate;
using Project1Demo.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.DataAccess.Concrete.NHiberNate
{
    public class Helper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.
                ConnectionString(c => c.Server(@"(localdb)\mssqllocaldb").Database("Example").TrustedConnection())).
                Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).
                BuildSessionFactory();
        }
    }
}
