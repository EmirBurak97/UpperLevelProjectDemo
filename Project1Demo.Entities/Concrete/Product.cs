﻿using Project1Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.Entities.Concrete
{
    public class Product:IEntity
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual Int16 UnitsInStock { get; set; }
    }
}
