using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataInfrastructure
{
   public interface IDataAC <TEntity>
    {
        IQueryable<TEntity> GetAll();
        IQueryable GetAllWithIncludes(object id, params Expression<Func<TEntity, object>>[] includes);
        TEntity GetById(object id);

        TEntity GetByIdWithIncludes(object id, params Expression<Func<TEntity, object>>[] includes);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity,object id);
        TEntity Update(TEntity entity, params object[] id);
        void Delete(TEntity entity);
        IQueryable<TEntity> GetCompiledQuery(Expression<Func<TEntity, bool>> predicate);
            
    }
}
