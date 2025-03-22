using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;


namespace Accounting.DataLayer.Services
{
    class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private Accounting_DBEntities _DB;
        private DbSet<TEntity> _DbSet;

        public GenericRepository(Accounting_DBEntities dB)
        {
            _DB = dB;
            _DbSet = _DB.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _DbSet;
            if (where != null)
                query = query.Where(where);
            return query.ToList();
        }

        public virtual TEntity GetByID(object ID)
        {
            return _DbSet.Find(ID);
        }

        public virtual void Delete(TEntity entity)
        {
            if (_DB.Entry(entity).State == EntityState.Detached)
                _DbSet.Attach(entity);
            _DbSet.Remove(entity);
        }

        public virtual void Delete(object ID)
        {
            var entity = GetByID(ID);
            Delete(entity);
        }

        public virtual void Insert(TEntity entity)
        {
            _DbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            if (_DB.Entry(entity).State == EntityState.Detached)
                _DbSet.Attach(entity);
            _DB.Entry(entity).State = EntityState.Modified;
        }
    }
}
