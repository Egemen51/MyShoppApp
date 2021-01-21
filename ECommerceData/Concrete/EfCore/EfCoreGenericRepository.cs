using ECommerceData.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        public void Create(TEntity entitiy)
        {
            using (var context=new TContext())
            {
                context.Set<TEntity>().Add(entitiy);
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entitiy)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entitiy);
                context.SaveChanges();
            }
           
        }

        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entitiy)
        {
            using (var context = new TContext())
            {
                context.Entry(entitiy).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
