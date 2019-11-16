using TradingCompany.DAL.Models.Filters.Abstractions;
using System;
using System.Collections.Generic;

namespace TradingCompany.DAL.Repositories.Abstractions
{
    public interface IRepository<TEntity, TFilter>
    {
        TEntity Get(TFilter filter = default(TFilter));

        IEnumerable<TEntity> GetRange(TFilter filterLeft, TFilter filterRight, TFilter filter = default(TFilter));

        IEnumerable<TEntity> GetAll(TFilter filter = default(TFilter));

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity, TFilter filter = default(TFilter));

        bool Delete(TFilter filter = default(TFilter));
    }
}

