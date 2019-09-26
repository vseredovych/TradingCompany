using System;
using System.Collections.Generic;
using TradingCompany.DAL.Models.Entities.Abstractions;
using TradingCompany.DAL.Models.Filters.Abstractions;

namespace TradingCompany.DAL.Models.Filters.Implementations
{
    public class UserFilter : IFilterable
    {
        public ulong? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string HashPassword { get; set; }

        public ulong? RoleId { get; set; }
    }
}
