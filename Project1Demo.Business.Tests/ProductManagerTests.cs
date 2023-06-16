using FluentValidation;
using Moq;
using Project1Demo.Business.Concrete.Managers;
using Project1Demo.DataAccess.Abstract;
using Project1Demo.Entities.Concrete;
using System.Runtime.Versioning;

namespace Project1Demo.Business.Tests
{
    public class ProductManagerTests
    {       
        [Fact]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock= new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            Action act = ()=> productManager.Add(new Product());

            ValidationException validationException = Assert.Throws<ValidationException>(act);
        }
    }
}