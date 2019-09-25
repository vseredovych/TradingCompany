﻿using SalesOut.DAL.Models.Filters.Implementations;
using SalesOut.DAL.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SalesOut.DAL.Models.Entities.Abstractions;

namespace SalesOut.DAL.Models.Entities.Implementations
{
    public class User : IBaseEntity
    {
        public ulong Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string HashPassword { get; set; }

        public ulong RoleId { get; set; }

        public override string ToString()
        {
            return string.Format("Id = {0}\nName = {1}\n SurName={2} \nEmail = {3} \nHashPassword = {4}\nRoleId={5}",
                Id, FirstName, LastName, Email, HashPassword, RoleId);
        }

    }
}
