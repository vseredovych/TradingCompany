using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOut.DAL.Core
{
    public class DbCommandManager
    {

        private readonly string _tableName;

        //        "Insert into {0} (FirstName, LastName, Email, HashPassword, RoleId) " +
            //                                             "output inserted.Id " +
          //                                           "values (@FirstName, @LastName, @Email, @HashPassword, @RoleId);"

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

        public string GetSellectCommand(List<string> entity, List<string> filter)
        {

            return "";
        }

        public string GetSellectRangeCommand(List<string> entity, List<string> filter)
        {

            return "";
        }

        public string GetUpdateCommand(List<string> entity, List<string> filter)
        {
            string values = "";
            string condition = "";
            string command = "";

            if ( entity != null && entity.Count > 0 )
            {
                values = string.Format("{0}",
                    string.Format(entity[0] + " = @")  + entity.Aggregate((a, b) => a + ", " + b + " = @" + b));
            }
            if (entity != null && entity.Count > 0 )
            {
                condition = string.Format("Where {0}",
                    string.Format("@" + entity.Aggregate((a, b) => a + ", @" + b)));
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

        public string GetDeleteCommand(List<string> entity, List<string> filter)
        {



            return "";
        }
    }
}
