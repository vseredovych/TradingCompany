using System;
using System.Collections.Generic;

namespace SalesOut.DAL.Models.Entities.Abstractions
{

    //public interface IRepository<TEnt> { }

    public interface IRepository<TEntity>
    {
        TEntity Get(ulong id);

        IEnumerable<TEntity> GetAll();

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        bool Delete(TEntity entity);
    }
}

