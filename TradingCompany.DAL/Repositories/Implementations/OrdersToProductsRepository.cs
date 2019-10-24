﻿using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace TradingCompany.DAL.Repositories.Implementations
{
    public class OrderToProductsRepository : BasicRepository<OrderToProduct, OrderToProductFilter>
    {
        internal static readonly string tableName = "tblOrdersToProducts";

        public OrderToProductsRepository() : base(tableName) { }

        //CRUD
        internal override OrderToProduct FillEntity(DbDataReader reader)
        {
            if (reader.HasRows == false)
            {
                return null;
            }
            try
            {
                OrderToProduct entity = new OrderToProduct();
                //entity.Id = Convert.ToUInt64(reader["Id"]);
                entity.ProductId = Convert.ToUInt64(reader["ProductId"]);
                entity.OrderId = Convert.ToUInt64(reader["OrderId"]);
                entity.Quantity = Convert.ToInt32(reader["Quantity"]);

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal override List<DbParameter> GetParameters(OrderToProductFilter filter, string prefix = "")
        {
            if (filter == null)
            {
                return new List<DbParameter>();
            }
            try
            {
                prefix = "@" + prefix;
                List<DbParameter> parameters = new List<DbParameter>();
                //if (filter.Id != null)
                //{
                //    parameters.Add(dbManager.CreateParameter(prefix + "Id", filter.Id, DbType.Int64));
                //}
                if (filter.ProductId != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "ProductId", 50, filter.ProductId, DbType.Int64));
                }
                if (filter.OrderId != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "OrderId", 50, filter.OrderId, DbType.Int64));
                }
                if (filter.Quantity != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "Quantity", 50, filter.Quantity, DbType.Int32));
                }
                return parameters;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal override List<DbParameter> GetParameters(OrderToProduct entity, string prefix = "")
        {
            return GetParameters(EntityToFilter(entity), prefix);
        }
        internal override List<string> GetFilterValues(OrderToProductFilter entity)
        {
            if (entity == null)
            {
                return new List<string>();
            }
            List<string> valuesList = new List<string>();

            //if (entity.Id != null)
            //{
            //    valuesList.Add("Id");
            //}
            if (entity.ProductId != null)
            {
                valuesList.Add("ProductId");
            }
            if (entity.OrderId != null)
            {
                valuesList.Add("OrderId");
            }
            if (entity.Quantity != null)
            {
                valuesList.Add("Quantity");
            }
            return valuesList;
        }
        internal override List<string> GetEntityValues(OrderToProduct entity)
        {
            return GetFilterValues(EntityToFilter(entity));
        }
    }
}
