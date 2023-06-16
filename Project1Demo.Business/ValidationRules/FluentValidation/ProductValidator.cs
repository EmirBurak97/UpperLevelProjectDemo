using FluentValidation;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty();
            RuleFor(p=>p.CategoryId).NotEmpty();
            RuleFor(p=>p.UnitPrice).GreaterThan(0);
            RuleFor(p=>p.UnitsInStock).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 20);
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(p => p.CategoryId == 1);

        }
    }
}
