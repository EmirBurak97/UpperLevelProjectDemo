using Ninject.Modules;
using Project1Demo.Business.Abstract;
using Project1Demo.Business.Concrete.Managers;
using Project1Demo.Core.DataAccess;
using Project1Demo.Core.DataAccess.EntityFramework;
using Project1Demo.Core.DataAccess.NHiberNate;
using Project1Demo.DataAccess.Abstract;
using Project1Demo.DataAccess.Concrete.EntityFramework;
using Project1Demo.DataAccess.Concrete.NHiberNate;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepositoryBase<>));
            Bind<DbContext>().To<ExampleContext>();
            Bind<NHibernateHelper>().To<Helper>();
        }
    }
}
