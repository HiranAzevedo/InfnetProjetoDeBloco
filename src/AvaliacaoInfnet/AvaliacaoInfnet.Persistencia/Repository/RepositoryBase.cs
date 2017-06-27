using AvaliacaoInfnet.Domain.Interfaces;
using AvaliacaoInfnet.Persistencia.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AvaliacaoInfnet.Persistencia.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected AvaliacaoInfnetContext Db = new AvaliacaoInfnetContext();

    
        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
            //return Db.Set<TEntity>().AsNoTracking().ToList(); // Não usa LazyLoad se não há tracking.
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }
        
        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }       
    }
}
