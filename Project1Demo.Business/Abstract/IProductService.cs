﻿using PostSharp.Aspects.Serialization;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.Business.Abstract
{
    public interface IProductService
    {

        List<Product> GetAll();

        Product GetById(int id);

        Product Add(Product product);
        Product Update(Product product);

        void TransactionalOperation(Product product1, Product product2);
    }
}
