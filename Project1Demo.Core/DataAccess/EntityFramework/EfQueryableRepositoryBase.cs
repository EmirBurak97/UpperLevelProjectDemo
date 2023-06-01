using Project1Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Demo.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepositoryBase<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private IDbSet<T> _entities;

        public EfQueryableRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => this._entities;

        protected virtual IDbSet<T> Entities 
        {
            get { return _entities ?? (_entities = _context.Set<T>()); } //entities null ise entitiesi context t ye abone et yani içini doldur.
        }

    }
}
