using SalesOut.DAL.Core;
using SalesOut.DAL.Models.Entities.Abstractions;
using SalesOut.DAL.Models.Entities.Implementations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace SalesOut.DAL.Repositories.Implementations
{
    public class UsersRepository : IRepository<User>
    {
        public readonly string _databaseTable = "tblUsers";
        DbManager dbManager = new DbManager();

        //CRUD
        public User Create(User user)
        {
            string commandText = string.Format("Insert into {0} (FirstName, LastName, Email, HashPassword, Role) " +
                                               "output inserted.Id " +
                                               "values (@FirstName, @LastName, @Email, @HashPassword, @Role);", _databaseTable);
            var parameters = GetParametrs(user);
            user.Id =  Convert.ToUInt64(dbManager.GetScalarValue(commandText, parameters));
       
            return user;
        }
        public User Update(User user)
        {
            string commandText = string.Format("Update {0} " +
                "Set " +
                "FirstName = @FirstName, " +
                "LastName = @LastName, " +
                "Email = @Email, " +
                "HashPassword = @HashPassword, " +
                "Role = @Role " +
                "output inserted.Id " +
                "Where Id = @Id;", _databaseTable);

            var parameters = GetParametrs(user);
            user.Id = Convert.ToUInt64(dbManager.GetScalarValue(commandText, parameters));

            return user;
        }
        public bool Delete(User user)
        {
            string commandText = string.Format( "Delete from {0} " +
                                                "output deleted.Id " +
                                                "where Id = @Id", _databaseTable);
            var parameters = GetParametrs(user);
            ulong deletedId = Convert.ToUInt64(dbManager.GetScalarValue(commandText, parameters));

            if (user.Id == deletedId)
            {
                return true;
            }
            return false;
        }

        public bool Delete(ulong id)
        {
            string commandText = string.Format( "Delete from {0} " +
                                                "output deleted.Id " +
                                                "where Id = @Id;", _databaseTable);

            List<DbParameter> parameters = new List<DbParameter>();
            parameters.Add(dbManager.CreateParameter("@Id", id, DbType.Int64));
            ulong deletedId = Convert.ToUInt64(dbManager.GetScalarValue(commandText, parameters));

            if (id == deletedId)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<User> GetAll()
        {
            string commandText = string.Format("Select * from {0};", _databaseTable);
            List<User> users = new List<User>();
            User user = new User();

            using (var connection = dbManager.CreateConnection())
            {
                connection.Open();
                var command = dbManager.CreateDbCommand(connection, commandText);
                DbDataReader reader = dbManager.GetDataReader(commandText);

                if (reader.IsClosed)
                {
                    return users;
                }

                while (reader.Read())
                {
                    user = FillEntity(reader);
                    users.Add(user);
                }
                return users;
            }
        }
        public IEnumerable<User> GetRange(ulong start, ulong end)
        {
            string commandText = string.Format("Select * from {0} " +
                                                "where Id >= @Start and Id <= @End;", _databaseTable);
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            List<User> users = new List<User>();
            User user = new User();

            parameters.Add(dbManager.CreateParameter("@Start", start, DbType.Int64));
            parameters.Add(dbManager.CreateParameter("@End", end, DbType.Int64));


            using (var connection = dbManager.CreateConnection())
            {
                connection.Open();
                var command = dbManager.CreateDbCommand(connection, commandText);
                DbDataReader reader = dbManager.GetDataReader(commandText, parameters);

                if (reader.IsClosed)
                {
                    return users;
                }

                while (reader.Read())
                {
                    user = FillEntity(reader);
                    users.Add(user);
                }
                return users;
            }
        }
        public User Get(ulong id)
        {
            string commandText = string.Format("select * from {0} where Id = @Id;", _databaseTable);
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(dbManager.CreateParameter("@Id", id, DbType.Int64));
            var reader = dbManager.GetDataReader(commandText, parameters);

            User user = new User();
            if (reader.IsClosed)
            {
                return user;
            }

            try
            {
                reader.Read();
                user = FillEntity(reader);

                return user;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }
        public ulong GetScalarValue(string commandText)
        {
            List<DbParameter> parameters = new List<DbParameter>();
            object scalarValue = dbManager.GetScalarValue(commandText, parameters);
            return Convert.ToUInt64(scalarValue);
        }

        public User FillEntity(DbDataReader reader)
        {
            User user = new User();
            user.Id = Convert.ToUInt64(reader["Id"]);
            user.FirstName = reader["FirstName"].ToString();
            user.LastName = reader["LastName"].ToString();
            user.Email = reader["Email"].ToString();
            user.HashPassword = reader["HashPassword"].ToString();
            user.Role = reader["Role"].ToString();

            return user;
        }

        public List<DbParameter> GetParametrs(User user)
        {
            List<DbParameter> parameters = new List<DbParameter>();
            parameters.Add(dbManager.CreateParameter("@Id", user.Id, DbType.Int64));
            parameters.Add(dbManager.CreateParameter("@FirstName", 50, user.FirstName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@LastName", 50, user.LastName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@Email", 50, user.Email, DbType.String));
            parameters.Add(dbManager.CreateParameter("@HashPassword", 50, user.HashPassword, DbType.String));
            parameters.Add(dbManager.CreateParameter("@Role", 50, user.Role, DbType.String));
            return parameters;
        }
    }
}
