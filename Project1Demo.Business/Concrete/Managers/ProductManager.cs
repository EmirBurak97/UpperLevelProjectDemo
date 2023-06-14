using Project1Demo.Business.Abstract;
using Project1Demo.Business.ValidationRules.FluentValidation;
using Project1Demo.DataAccess.Abstract;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }
        [FluentValidate(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
        [FluentValidate(typeof(ProductValidator))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }
    }
}
