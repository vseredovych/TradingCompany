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
        void Delete(ulong id);
        void Update(ulong id);
        IEnumerable<TEnity> GetAll();
        void OutputValues();
    }
}
