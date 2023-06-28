using Project1Demo.Business.Abstract;
using Project1Demo.Business.ValidationRules.FluentValidation;
using Project1Demo.DataAccess.Abstract;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1Demo.Business.Aspects.PostSharp;
using Project1Demo.Core.CrossCuttingConcerns.Validation.FluentValidation;
using Project1Demo.Business.Aspects.PostSharp.ValidationAspects;
using Project1Demo.Business.Aspects.PostSharp.TransactionAspects;
using Project1Demo.Business.Aspects.PostSharp.CacheAspects;
using System.CodeDom;
using Project1Demo.Core.CrossCuttingConcerns.Caching;
using Project1Demo.Core.CrossCuttingConcerns.Caching.Microsoft;

namespace Project1Demo.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }
        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            _productDal.Update(product2);
        }
    }
}
