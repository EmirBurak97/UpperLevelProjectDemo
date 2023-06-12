using FluentNHibernate.Mapping;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.DataAccess.Concrete.NHiberNate.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap() 
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryId).Column("CategoryId");

            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}
