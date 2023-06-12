using Project1Demo.Core.DataAccess.NHiberNate;
using Project1Demo.DataAccess.Abstract;
using Project1Demo.Entities.ComplexTypes;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.DataAccess.Concrete.NHiberNate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernate) : base(nHibernate)
        {
            nHibernate = _nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using(var session =  _nHibernateHelper.OpenSession()) 
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>()
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                             };
                return result.ToList();
            }
        }
    }
}
