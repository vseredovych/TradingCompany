using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.DAL.Core
{
    public class DbCommandManager
    {

        private readonly string _tableName;

        public DbCommandManager(string _tableName)
        {
            this._tableName = _tableName;
        }

        public string GetInsertCommand(List<string> entity)
        {
            string command = string.Format("Insert into {0} " +
                "( {1} ) " +
                "output inserted.Id " +
                "values " +
                "( {2} );", 
                _tableName,
                entity.Aggregate((a, b) => a + ", " + b), 
                string.Format( "@" + entity.Aggregate( (a, b) =>  a + ", @" + b) ) );

            return command;
        }
        public string GetUpdateCommand(List<string> entity, List<string> filter, string prefix = "")
        {
            string values = "";
            string condition = "";
            string command = "";

            if (entity != null && entity.Count > 0)
            {
                values = string.Format("{0}",
                    string.Format(entity[0] + " = @") + entity.Aggregate((a, b) => a + ", " + b + " = @" + b));
            }
            if (filter != null && filter.Count > 0)
            {
                condition = string.Format("Where {0}",
                    string.Format(filter[0] + " = @" + prefix) + filter.Aggregate((a, b) => a + "AND " + b + " = @" + prefix + b));
            }
            else
            {
                throw new Exception("No conditons for \"SET\" querry!");
            }

            command = string.Format("Update {0} " +
                    "Set " +
                    "{1} " +
                    "output inserted.Id " +
                    "{2} " +
                    ";", _tableName, values, condition);

            return command;
        }
        public string GetSellectCommand(List<string> filter)
        {
            string condition = "";
            string command = "";

            if (filter != null && filter.Count > 0)
            {
                condition = string.Format("Where {0}",
                    string.Format(filter[0] + " = @") + filter.Aggregate((a, b) => a + " AND " + b + " = @" + b));
            }

            command = string.Format("select * from {0} {1};", _tableName, condition);

            return command;
        }
        public string GetSellectAllCommand(List<string> filter)
        {
            string condition = "";
            string command = "";

            if (filter != null && filter.Count > 0)
            {
                condition = string.Format("Where {0}",
                    string.Format(filter[0] + " = @") + filter.Aggregate((a, b) => a + " AND " + b + " = @" + b));
            }

            command = string.Format("select * from {0} {1};", _tableName, condition);

            return command;
        }

        public string GetSellectRangeCommand(List<string> filterLeft, string leftPrefix, List<string> filterRight, string rightPrefix, List<string> filter)
        {
            string conditionGreater = "";
            string conditionFewer = "";
            string condition = "";
            string command = "";

            if (filterLeft != null && filterLeft.Count > 0)
            {
                conditionGreater = string.Format( string.Format(filterLeft[0] + " > @" + leftPrefix ) +
                    filterLeft.Aggregate((a, b) => a + " AND " + b + " > @" + leftPrefix + b) );
            }
            if (filterRight != null && filterRight.Count > 0)
            {
                conditionFewer = string.Format( string.Format(filterRight[0] + " < @" + rightPrefix ) +
                    filterRight.Aggregate((a, b) => a + " AND " + b + " < @" + rightPrefix + b) );
            }
            if (filter != null && filter.Count > 0)
            {
                condition = string.Format( string.Format(filter[0] + " = @" ) +
                    filter.Aggregate((a, b) => a + " AND " + b + " = @" + b) );
            }
            if ( condition != "" || conditionFewer != "" || conditionFewer  != "")
            {
                List<string> conditionsList = new List<string>() { condition, conditionGreater, conditionFewer };
                conditionsList.Remove("");
                condition = "Where " + conditionsList.Aggregate((a, b) =>  a + " AND " + b);
            }
            command = string.Format("select * from {0} {1} ;", _tableName, condition);

            return command;
        }


        public string GetDeleteCommand(List<string> filter)
        {
            string commandText = string.Format("Delete from {0} " +
                                       "output deleted.Id " +
                                       "where Id = @Id", _tableName);

            string condition = "";
            string command = "";

            if (filter != null && filter.Count > 0)
            {
                condition = string.Format("Where {0}",
                    string.Format(filter[0] + " = @") + filter.Aggregate((a, b) => a + " AND " + b + " = @" + b));
            }

            command = string.Format("Delete from {0} " +
                "output deleted.Id " +
                "{1} ;", _tableName, condition);

            return command;
        }
    }
}
