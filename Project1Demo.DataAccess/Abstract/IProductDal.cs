﻿using Project1Demo.Core.DataAccess;
using Project1Demo.Entities.ComplexTypes;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        public List<ProductDetail> GetProductDetails();
    }
}
