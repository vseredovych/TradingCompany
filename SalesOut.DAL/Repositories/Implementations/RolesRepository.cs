//using SalesOut.DAL.Core;
//using SalesOut.DAL.Models.Entities.Abstractions;
//using SalesOut.DAL.Models.Entities.Implementations;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Common;

//namespace SalesOut.DAL.Repositories.Implementations
//{
//    public class MerchantsOperations : IRepository<Role>
//    {
//        string databaseTable = "Merchants";
//        DbManager dbManager = new DbManager();

//        //CRUD
//        public void Insert(Role user)
//        {
//            string commandText = "Insert into " + databaseTable + " (Id, FirstName, LastName, Salary, CurrentCity)" +
//                                 "values (@Id, @FirstName, @LastName, @Salary, @CurrentCity);";
//            var parameters = GetParametrs(user);
//            dbManager.CommandExecuteNonQuery(commandText, parameters);

//        }
//        public void Update(Role user)
//        {
//            string commandText = "Update " + databaseTable + " Set FirstName = @FirstName, " +
//                "LastName = @LastName, " +
//                "Salary = @Salary, " +
//                "CurrentCity = @CurrentCity " +
//                "Where Id = @Id;";
//            var parameters = GetParametrs(user);
//            dbManager.CommandExecuteNonQuery(commandText, parameters);
//        }
//        public void Delete(Role user)
//        {
//            string commandText = "Delete from " + databaseTable + " where Id = @Id";
//            var parameters = GetParametrs(user);
//            dbManager.CommandExecuteNonQuery(commandText, parameters);
//        }

//        public void Delete(long id)
//        {
//            string commandText = "Delete from " + databaseTable + " where Id = @Id";
//            List<DbParameter> parameters = new List<DbParameter>();
//            parameters.Add(dbManager.CreateParameter("@Id", id, DbType.UInt32));
//            dbManager.CommandExecuteNonQuery(commandText, parameters);
//        }

//        public List<Role> GetAll()
//        {
//            string commandText = "Select * from " + databaseTable + ";";
//            List<Role> users = new List<Role>();

//            using (var connection = dbManager.CreateConnection())
//            {
//                connection.Open();
//                var command = dbManager.CreateDbCommand(connection, commandText);
//                DbDataReader reader = command.ExecuteReader();

//                while (reader.Read())
//                {
//                    Role user = new Role();
//                    user.Id = Convert.ToInt32(reader["Id"]);
//                    user.Name = reader["Name"].ToString();
//                    users.Add(user);
//                }
//                return users;
//                //}
//            }
//        }
//        public List<Role> GetInRange(long start, long end)
//        {
//            string commandText = "Select * from " + databaseTable + " group by Salary having Salary > @Start and Salary < @End;";
//            List<DbParameter> parameters = new List<DbParameter>();
//            List<Role> users = new List<Role>();

//            parameters.Add(dbManager.CreateParameter("@Start", start, DbType.UInt32));
//            parameters.Add(dbManager.CreateParameter("@End", end, DbType.UInt32));


//            using (var connection = dbManager.CreateConnection())
//            {
//                connection.Open();
//                var command = dbManager.CreateDbCommand(connection, commandText);
//                DbDataReader reader = dbManager.GetDataReader(commandText, parameters);

//                while (reader.Read())
//                {
//                    Role user = new Role();
//                    user.Id = Convert.ToInt32(reader["Id"]);
//                    user.Name = reader["Name"].ToString();
//                    users.Add(user);
//                }
//                return users;
//            }
//        }
//        public Role Get(long id)
//        {
//            var parameters = new List<IDbDataParameter>();
//            parameters.Add(dbManager.CreateParameter("@Id", id, DbType.Int64));

//            string commandText = "select * from " + databaseTable + " where Id = @Id;";
//            var dataReader = dbManager.GetDataReader(commandText);
//            try
//            {
//                var user = new Role();
//                while (dataReader.Read())
//                {
//                    user.Id = Convert.ToInt32(dataReader["Id"]);
//                }
//                return user;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            finally
//            {
//                dataReader.Close();
//            }
//        }
//        public long GetScalarValue(string commandText)
//        {
//            List<DbParameter> parameters = new List<DbParameter>();
//            object scalarValue = dbManager.GetScalarValue(commandText, parameters);
//            return Convert.ToInt64(scalarValue);
//        }
//        public List<DbParameter> GetParametrs(Role user)
//        {
//            List<DbParameter> parameters = new List<DbParameter>();
//            parameters.Add(dbManager.CreateParameter("@Id", user.Id, DbType.Int64));
//            parameters.Add(dbManager.CreateParameter("@FirstName", 50, user.Name, DbType.String));
//            return parameters;
//        }
//    }
//}
