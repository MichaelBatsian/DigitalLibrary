using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Godeltech.Mastery.DigitalLibrary.DAL.Interfaces;


namespace Godeltech.Mastery.DigitalLibrary.DAL.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;

        protected GenericRepository(DbContext context)
        {
            Context = context;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public virtual T Get(T item)
        {
            return Context.Set<T>().Find(item);
        }

        public virtual IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return Context.Set<T>().Where(predicate).ToList();
        }

        public virtual void Create(T item)
        {
            Context.Set<T>().Add(item);
        }

        public virtual void Delete(T item)
        {
            Context.Set<T>().Remove(item);
        }

        public virtual void Update(T item)
        {
            Context.Entry(item).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

    }
}
