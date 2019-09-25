using SalesOut.DAL.Core;
using SalesOut.DAL.Models;
using SalesOut.DAL.Models.Entities.Implementations;
using SalesOut.DAL.Models.Filters.Implementations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace SalesOut.DAL.Repositories.Implementations
{
    public class UsersRepository : BasicRepository<User, UserFilter>
    {
        //public readonly string _tableName = "tblUsers";
        internal static readonly string tableName = "tblUsers";

        public UsersRepository() : base(tableName) { }
        //CRUD

        internal override User FillEntity(DbDataReader reader)
        {
            try
            {
                User entity = new User();
                entity.Id = Convert.ToUInt64(reader["Id"]);
                entity.FirstName = reader["FirstName"].ToString();
                entity.LastName = reader["LastName"].ToString();
                entity.Email = reader["Email"].ToString();
                entity.HashPassword = reader["HashPassword"].ToString();
                entity.RoleId = Convert.ToUInt64(reader["RoleId"]);

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal override List<DbParameter> GetParametrs(UserFilter entity)
        {
            try
            {
                List<DbParameter> parameters = new List<DbParameter>();
                if (entity.Id != null)
                {
                    parameters.Add(dbManager.CreateParameter("@Id", entity.Id, DbType.Int64));
                }
                if (entity.FirstName != null)
                {
                    parameters.Add(dbManager.CreateParameter("@FirstName", 50, entity.FirstName, DbType.String));
                }
                if (entity.LastName != null)
                {
                    parameters.Add(dbManager.CreateParameter("@LastName", 50, entity.LastName, DbType.String));
                }
                if (entity.Email != null)
                {
                    parameters.Add(dbManager.CreateParameter("@Email", 50, entity.Email, DbType.String));
                }
                if (entity.HashPassword != null)
                {
                    parameters.Add(dbManager.CreateParameter("@HashPassword", 50, entity.HashPassword, DbType.String));
                }
                if (entity.RoleId != null)
                {
                    parameters.Add(dbManager.CreateParameter("@RoleId", 50, entity.RoleId, DbType.String));
                }
                return parameters;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal override List<DbParameter> GetParametrs(User entity)
        {
            return GetParametrs(EntityToFilter(entity));
        }
        internal override List<string> GetEntityValues(UserFilter entity)
        {
            List<string> valuesList = new List<string>();

            if (entity.Id != null)
            {
                valuesList.Add("Id");
            }
            if (entity.FirstName != null)
            {
                valuesList.Add("FirstName");
            }
            if (entity.LastName != null)
            {
                valuesList.Add("LastName");
            }
            if (entity.Email != null)
            {
                valuesList.Add("Email");
            }
            if (entity.HashPassword != null)
            {
                valuesList.Add("HashPassword");
            }
            if (entity.RoleId != null)
            {
                valuesList.Add("RoleId");
            }
            return valuesList;
        }
        internal override List<string> GetEntityValues(User entity)
        {
            return GetEntityValues(EntityToFilter(entity));
        }
        internal override UserFilter EntityToFilter(User entity)
        {
            return new UserFilter()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                HashPassword = entity.HashPassword,
                RoleId = entity.RoleId
            };
        }
    }
}
