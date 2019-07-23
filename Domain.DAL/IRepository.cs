using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Domain.DAL
{
   public interface IRepository:IDisposable
    {
       TEntity Create<TEntity>(TEntity toCreate) where TEntity : class;
       bool Delete<TEntity>(TEntity toDelete) where TEntity : class;
       bool Update<Tentity>(Tentity toUpdate) where Tentity : class;
       TEntity Retrieve<TEntity>(Expression<Func<TEntity,bool>> criteria)
            where TEntity: class;
       List<TEntity> Filter<TEntity>(Expression<Func<TEntity, bool>> criteria)
           where TEntity : class;
    }
}
