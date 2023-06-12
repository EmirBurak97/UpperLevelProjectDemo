using Project1Demo.Core.DataAccess.NHiberNate;
using Project1Demo.DataAccess.Abstract;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.DataAccess.Concrete.NHiberNate
{
    public class NhCategoryDal : NhEntityRepositoryBase<Category>, ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper nHibernate) : base(nHibernate)
        {
        }
    }
}
