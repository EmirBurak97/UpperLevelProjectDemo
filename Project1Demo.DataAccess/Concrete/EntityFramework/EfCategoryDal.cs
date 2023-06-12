using Project1Demo.Core.DataAccess.EntityFramework;
using Project1Demo.DataAccess.Abstract;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,ExampleContext>,ICategoryDal
    {
    }
}
