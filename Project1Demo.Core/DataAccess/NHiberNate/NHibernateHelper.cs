using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.Core.DataAccess.NHiberNate
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public virtual ISessionFactory SessionFactory 
        {
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); } // varsa olanı kullan yoksa kendin initialize et
        }

        protected abstract ISessionFactory InitializeFactory(); //Hepsinin ayrı ayrı implementasyonu için kullanılır

        public virtual ISession OpenSession() //Ef'deki Context açmak.
        {
            return SessionFactory.OpenSession();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this); // bu bir kalıptır dispose'larda standartdır.
        }
    }
}
