﻿using Project1Demo.Core.DataAccess.EntityFramework;
using Project1Demo.DataAccess.Abstract;
using Project1Demo.Entities.ComplexTypes;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ExampleContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using(ExampleContext context = new ExampleContext()) 
            {
                var result = from p in context.Products
                             join c in context.Categories
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
