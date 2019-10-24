using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.ConsoleUI.Abstractions.RepoMenu
{
    public interface IMenu<TRepository, TEnity>
    {
        void Add();
        void Delete(int id);
        void Update(int id);
        IEnumerable<TEnity> GetAll();
    }
}
