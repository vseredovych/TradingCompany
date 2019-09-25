using SalesOut.DAL.Models.Entities.Abstractions;
using SalesOut.DAL.Core;

using System;
using System.Collections.Generic;
using SalesOut.DAL.Repositories.Implementations;
using System.Data.Common;
using SalesOut.DAL.Models.Filters.Implementations;
using SalesOut.DAL.Repositories.Abstractions;
using System.Data;
using SalesOut.DAL.Models;

namespace SalesOut.DAL.Repositories
{
    public class BasicRepository<TEntity, TFilter> : IRepository<TEntity, TFilter> 
        where TEntity: IBaseEntity, new()
        where TFilter: IFilterable, new()
    {
        internal readonly string _tableName;
        internal DbManager dbManager;
        internal DbCommandManager commandBuilder;

        public BasicRepository(string tableName)
        {
            _tableName = tableName;
            commandBuilder = new DbCommandManager(_tableName);
            dbManager = new DbManager();

        }

        public TEntity Create(TEntity entity)
        {
            TFilter filter = EntityToFilter(entity);
            filter.Id = null;

            string commandText = commandBuilder.GetInsertCommand(GetEntityValues(filter));
            var parameters = GetParametrs(filter);


            try
            {

                entity.Id = Convert.ToUInt64(dbManager.GetScalarValue(commandText, parameters));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return entity;
        }

        public TEntity Update(TEntity entity, IFilterable filter = null)
        {
            string commandText = string.Format("Update {0} " +
                "Set " +
                "FirstName = @FirstName, " +
                "LastName = @LastName, " +
                "Email = @Email, " +
                "HashPassword = @HashPassword, " +
                "RoleId = @RoleId " +
                "output inserted.Id " +
                "Where Id = @Id;", _tableName);

            //var parameters = GetParametrs(new User);
            //try
            //{
            //    entity.Id = Convert.ToUInt64(dbManager.GetScalarValue(commandText, parameters));
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}

            return entity;
        }
        public bool Delete(IFilterable filter = null)
        {
            //string commandText = string.Format("Delete from {0} " +
            //                                    "output deleted.Id " +
            //                                    "where Id = @Id", _tableName);
            //var parameters = GetParametrs(entity);

            //try
            //{
            //    ulong deletedId = Convert.ToUInt64(dbManager.GetScalarValue(commandText, parameters));

            //    if (entity.Id == deletedId)
            //    {
            //        return true;
            //    }
            //    return false;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
            return true;
        }

        public bool Delete(ulong id, IFilterable filter = null)
        {
            string commandText = string.Format("Delete from {0} " +
                                                "output deleted.Id " +
                                                "where Id = @Id;", _tableName);
            List<DbParameter> parameters = new List<DbParameter>();
            parameters.Add(dbManager.CreateParameter("@Id", id, DbType.Int64));
            try
            {
                ulong deletedId = Convert.ToUInt64(dbManager.GetScalarValue(commandText, parameters));

                if (id == deletedId)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TEntity Get(ulong id, IFilterable filter = null)
        {
            string commandText = string.Format("select * from {0} where Id = @Id;", _tableName);
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(dbManager.CreateParameter("@Id", filter.Id, DbType.Int64));
            using (var reader = dbManager.GetDataReader(commandText, parameters))
            {
                TEntity entity = new TEntity();
                if (reader.IsClosed)
                {
                    return entity;
                }

                reader.Read();
                entity = FillEntity(reader);

                return entity;
            }
        }

        public IEnumerable<TEntity> GetRange(ulong idStart, ulong idEnd, IFilterable filter = null)
        {
            string commandText = string.Format("Select * from {0} " +
                                                "where Id >= @Start and Id <= @End;", _tableName);
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            List<TEntity> users = new List<TEntity>();
            TEntity entity = new TEntity();

            parameters.Add(dbManager.CreateParameter("@Start", idStart, DbType.Int64));
            parameters.Add(dbManager.CreateParameter("@End", idEnd, DbType.Int64));

            using (var reader = dbManager.GetDataReader(commandText, parameters))
            {

                if (reader.IsClosed)
                {
                    return users;
                }

                while (reader.Read())
                {
                    entity = FillEntity(reader);
                    users.Add(entity);
                }
                return users;
            }
        }

        public IEnumerable<TEntity> GetAll(IFilterable filter = null)
        {
            string commandText = string.Format("Select * from {0};", _tableName);
            List<TEntity> users = new List<TEntity>();
            TEntity entity = new TEntity();

            using (var reader = dbManager.GetDataReader(commandText))
            {

                if (reader.IsClosed)
                {
                    return users;
                }

                while (reader.Read())
                {
                    entity = FillEntity(reader);
                    users.Add(entity);
                }
                return users;
            }
        }
        //public ulong GetScalarValue(string commandText)
        //{
        //    List<DbParameter> parameters = new List<DbParameter>();
        //    try
        //    {
        //        object scalarValue = dbManager.GetScalarValue(commandText, parameters);
        //        return Convert.ToUInt64(scalarValue);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //public bool Delete(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public TEntity Get(ulong id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<TEntity> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public TEntity Update(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        virtual internal TEntity FillEntity(DbDataReader reader)
        {
            return new TEntity();
        }
        virtual internal List<string> GetEntityValues(TFilter filter)
        {
            return new List<string>();
        }
        virtual internal List<string> GetEntityValues(TEntity entity)
        {
            return new List<string>();
        }
        virtual internal List<DbParameter> GetParametrs(TFilter filter)
        {
            return new List<DbParameter>();
        }
        virtual internal List<DbParameter> GetParametrs(TEntity entity)
        {
            return new List<DbParameter>();
        }
        virtual internal TFilter EntityToFilter(TEntity entity)
        {
            return new TFilter();
        }
    }
}
