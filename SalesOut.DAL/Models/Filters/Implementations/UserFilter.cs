using SalesOut.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using SalesOut.DAL.Models.Entities.Abstractions;

namespace SalesOut.DAL.Models.Filters.Implementations
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
