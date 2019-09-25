using SalesOut.DAL.Models.Filters.Abstractions;
using System;
using System.Collections.Generic;

namespace SalesOut.DAL.Repository.Abstractions
{
    public interface IRepository<TEntity, TFilter>
    {
        TEntity Get(ulong id, TFilter filter = default(TFilter));

        IEnumerable<TEntity> GetRange(ulong idStart, ulong idEnd, TFilter filter = default(TFilter));

        IEnumerable<TEntity> GetAll(TFilter filter = default(TFilter));

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity, TFilter filter = default(TFilter));

        bool Delete(TFilter filter = default(TFilter));
    }
}

