using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.BLL.Services.Abstractions
{
    public interface IRoleService
    {
        List<string> GetRoleNames();
    }
}
