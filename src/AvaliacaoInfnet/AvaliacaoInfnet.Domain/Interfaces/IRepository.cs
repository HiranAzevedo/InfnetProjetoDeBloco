using System;
using System.Collections.Generic;

namespace AvaliacaoInfnet.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        void Remove(int id);

    }
}
