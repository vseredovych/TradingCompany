﻿using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Configuration;
using System;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SalesOut.DAL.Core
{
    public class DbManager
    {
        //private readonly string _invariant = "System.Data.SqlClient";
        public DbConnection CreateConnection()
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["SalesOut"].ConnectionString;

            return connection;
        }
        public void CloseConnection(DbConnection connection)
        {
            connection.Close();
        }
        public DbDataAdapter CreateDataAdapter(DbConnection connection)
        {
            return DbProviderFactories.GetFactory(connection).CreateDataAdapter();
        }
        public DbCommandBuilder CreateDbCommandBuilder(DbConnection connection)
        {
            return DbProviderFactories.GetFactory(connection).CreateCommandBuilder();
        }
        public DbParameter CreateDbParameter(DbConnection connection)
        {
            return DbProviderFactories.GetFactory(connection).CreateParameter();
        }
        public DbCommand CreateDbCommand(DbConnection connection)
        {
            return DbProviderFactories.GetFactory(connection).CreateCommand();
        }
        public DbCommand CreateDbCommand(DbConnection connection, string commandText)
        {
            var command = CreateDbCommand(connection);
            command.Connection = connection;
            command.CommandText = commandText;
            return command;
        }
        public DbParameter CreateParameter(string name, object value, DbType dbType)
        {
            return CreateParameter(name, 0, value, dbType, ParameterDirection.Input);
        }

        public DbParameter CreateParameter(string name, int size, object value, DbType dbType)
        {
            return CreateParameter(name, size, value, dbType, ParameterDirection.Input);
        }

        public DbParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction)
        {
            DbParameter parameter = CreateDbParameter(CreateConnection());
            parameter.DbType = dbType;
            parameter.ParameterName = name;
            parameter.Size = size;
            parameter.Direction = direction;
            parameter.Value = value;
            return parameter;
        }

        public DbDataReader GetDataReader(string commandText, IEnumerable<IDbDataParameter> parameters)
        {
            DbDataReader reader = null;

            try
            {
                var connection = this.CreateConnection();
                connection.Open();

                var command = this.CreateDbCommand(connection, commandText);


                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DbDataReader GetDataReader(string commandText)
        {
            DbDataReader reader = null;
            try
            {
                var connection = this.CreateConnection();
                connection.Open();

                var command = this.CreateDbCommand(connection, commandText);

                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void ExecuteNonQuery(string commandText, IEnumerable<IDbDataParameter> parameters)
        {
            using (var connection = this.CreateConnection())
            {
                connection.Open();

                using (var command = this.CreateDbCommand(connection, commandText))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    command.ExecuteNonQuery();
                }
            }
        }
        public void ExecuteNonQuery(string commandText)
        {
            using (var connection = this.CreateConnection())
            {
                connection.Open();

                using (var command = this.CreateDbCommand(connection, commandText))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public object GetScalarValue(string commandText, IEnumerable<IDbDataParameter> parameters = null)
        {
            using (var connection = this.CreateConnection())
            {
                connection.Open();

                using (var command = this.CreateDbCommand(connection, commandText))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }

                    return command.ExecuteScalar();
                }
            }
        }
        public void InsertWithTransaction(string commandText, List<IDbDataParameter> parameters = null)
        {
            IDbTransaction transaction = null;

            using (var connection = CreateConnection())
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                using (var command = CreateDbCommand(connection, commandText))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }

                    try
                    {
                        command.ExecuteNonQuery();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}