using Project1Demo.DataAccess.Concrete.EntityFramework.Mapping;
using Project1Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1Demo.DataAccess.Concrete.EntityFramework.Mapping;


namespace Project1Demo.DataAccess.Concrete.EntityFramework
{
    public class ExampleContext:DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ExampleContext()
        {
            Database.SetInitializer<ExampleContext>(null);
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());

        }
    }
}
