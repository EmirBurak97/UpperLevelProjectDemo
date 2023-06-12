using Project1Demo.DataAccess.Concrete.EntityFramework;

namespace Project1Demo.DataAccess.Tests.EntityFrameworkTests
{
    public class EntityFrameworkTest
    {
        [Fact]
        public void GetList_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList();
            Assert.Equal(26,result.Count);
            
        }

        [Fact]
        public void GetList_with_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList(p=>p.ProductName.Contains("ab"));
            Assert.Equal(26, result.Count);

        }
    }
}