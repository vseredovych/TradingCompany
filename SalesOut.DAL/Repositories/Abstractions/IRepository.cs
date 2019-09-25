using SalesOut.DAL.Models.Filters.Abstractions;
using System;
using System.Collections.Generic;

namespace SalesOut.DAL.Repository.Abstractions
{

    //public interface IRepository<TEnt> { }

    public interface IRepository<TEntity, TFilter>
    {
        TEntity Get(ulong id, IFilterable filter);

        IEnumerable<TEntity> GetRange(ulong idStart, ulong idEnd, IFilterable filter);

        IEnumerable<TEntity> GetAll(IFilterable filter);

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity, IFilterable filter);

        bool Delete(IFilterable filter);
    }
}

