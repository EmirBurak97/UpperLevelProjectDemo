using Project1Demo.DataAccess.Concrete.EntityFramework;
using Project1Demo.DataAccess.Concrete.NHiberNate;

namespace Project1Demo.DataAccess.Tests.NHiberNateTests
{
    public class NHiberNateTest
    {
        [Fact]
        public void GetList_returns_all_products()
        {
            NhPorductDal productDal = new NhPorductDal(new Helper());
            var result = productDal.GetList();
            Assert.Equal(26,result.Count);
            
        }

        [Fact]
        public void GetList_with_parameter_returns_filtered_products()
        {
            NhPorductDal productDal = new NhPorductDal(new Helper());
            var result = productDal.GetList(p=>p.ProductName.Contains("cheese"));
            Assert.Equal(1, result.Count);

        }
    }
}