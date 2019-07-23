using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Domain.DAL
{
   public class EFRepository:IRepository
    {

       DbContext Context;
       public EFRepository(DbContext context)
       {
           this.Context = context;
       }


        public TEntity Create<TEntity>(TEntity toCreate) where TEntity : class
        {
            TEntity Result = default(TEntity);
            try
            {
                Context.Set<TEntity>().Add(toCreate);
                Context.SaveChanges();
                Result = toCreate;
            }
            catch (Exception error)
            {
                throw error;
            }
            return Result;
        }

        public bool Delete<TEntity>(TEntity toDelete) where TEntity : class
        {
            bool result = false;
            try
            {
                Context.Entry<TEntity>(toDelete).State = EntityState.Deleted;
                result = Context.SaveChanges() > 0;
            }
            catch (Exception error)
            {
                throw error;
            }
            return result;
        }

        public bool Update<Tentity>(Tentity toUpdate) where Tentity : class
        {
            bool result = false;
            try
            {
                Context.Entry<Tentity>(toUpdate).State = EntityState.Modified;
                result = Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                
                throw;
            }
            return result;
        }

        public TEntity Retrieve<TEntity>(System.Linq.Expressions.Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            TEntity result = null;
            try
            {
                result = Context.Set<TEntity>().FirstOrDefault(criteria);
            }
            catch (Exception _err)
            {
                throw _err;
            }
            return result;
        }

        public List<TEntity> Filter<TEntity>(System.Linq.Expressions.Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            List<TEntity> result = null;
            try
            {
                result = Context.Set<TEntity>().Where(criteria).ToList();
            }
            catch (Exception _err)
            {
                throw _err;
            }
            return result;
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context = null;
            }
        }
    }
}
