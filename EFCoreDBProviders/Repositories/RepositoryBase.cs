using EFCoreDBProviders.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreDBProviders.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        protected readonly DbContext db;
        
        public RepositoryBase(DbContext dbContext) => db = dbContext;
        
        public virtual void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
        }

        public virtual TEntity GetById(int? id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public virtual void Update(TEntity obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public virtual void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public virtual void RemoveById(int? id)
        {
            var obj = GetById(id);
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}