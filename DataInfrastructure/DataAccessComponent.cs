using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataInfrastructure
{
    public class DataAccessComponent<TEntity> : IDataAC<TEntity>, IDisposable where TEntity : class
    {
        protected DbContext _context;

        #region [Constructor]
        /// <summary>
        /// The constructor is default used  ESFSEntities Context.
        /// </summary>
        public DataAccessComponent()
        {
            // _context = new Entities();
            _context.Configuration.LazyLoadingEnabled = false;
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public DataAccessComponent(bool lazyLoading = false)
        {
            // _context = new Entities();
            _context.Configuration.LazyLoadingEnabled = lazyLoading;
            _context.Configuration.ProxyCreationEnabled = false;
        }

        /// <summary>
        /// The constructor requires an open DataContext to work with
        /// </summary>
        /// <param name="context">An open DataContext</param>
        public DataAccessComponent(DbContext context)
        {
            _context = context;
            _context.Configuration.LazyLoadingEnabled = false;
            _context.Configuration.ProxyCreationEnabled = false;
        }

        #endregion

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

      
        

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable GetAllWithIncludes(object id, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(object id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByIdWithIncludes(object id, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetCompiledQuery(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity, params object[] id)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity, object id)
        {
            throw new NotImplementedException();
        }

        #region [Implement-IDisposable]
        public void Dispose()
        {
            if (_context != null) _context.Dispose();
        }
        #endregion
    }
}
