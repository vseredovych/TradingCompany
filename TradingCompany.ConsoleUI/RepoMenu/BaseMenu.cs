using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.ConsoleUI.Abstractions.RepoMenu;
using TradingCompany.DAL.Models.Entities.Abstractions;
using TradingCompany.DAL.Models.Filters.Abstractions;
using TradingCompany.DAL.Repository.Abstractions;

namespace TradingCompany.ConsoleUI.RepoMenu
{
    //    public abstract class BasicRepository<TEntity, TFilter> : IRepository<TEntity, TFilter>
    //    where TEntity : IBaseEntity, new()

    public abstract class BaseMenu<TRepository, TEntity, TFilter> : IMenu<TRepository, TEntity> 
        where TEntity : IBaseEntity, new()
        where TRepository : IRepository<TEntity, TFilter>, new()
    {
        TRepository repository;
        public BaseMenu()
        {
            repository = new TRepository();
        }
        public void Add()
        {
            TEntity entity = InputValues();
            repository.Create(entity);
        }
        public void Delete(int id)
        {
            TEntity entity = InputValues();
            repository.Create(entity);
        }
        public void Update(int id)
        {
            TEntity entity = InputValues();
            repository.Create(entity);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }
        protected void OutputValues()
        {
            foreach (var entity in GetAll())
            {
                Console.WriteLine(entity);
            }
        }
        protected virtual TEntity InputValues()
        {
            return new TEntity();
        }
    }
}
