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

        public string GetInsertCommand(List<string> values)
        {

            string command = string.Format("Insert into {0} " +
                "( {1} ) " +
                "output inserted.Id " +
                "values " +
                "( {2} );", 
                _tableName, 
                values.Aggregate((a, b) => a + ", " + b), 
                string.Format( "@" + values.Aggregate( (a, b) =>  a + ", @" + b) ) );

            return command;
        }

        public string GetSellectCommand(List<string> values)
        {

            return "";
        }

        public string GetSellectRangeCommand(List<string> values)
        {

            return "";
        }

        public string GetUpdateCommand(List<string> values)
        {
            string.Format("Update {0} " +
                "Set " +
                "FirstName = @FirstName, " +
                "LastName = @LastName, " +
                "Email = @Email, " +
                "HashPassword = @HashPassword, " +
                "RoleId = @RoleId " +
                "output inserted.Id " +
                "Where Id = @Id;", _tableName);


            return "";
        }

        public string GetDeleteCommand(Dictionary<string, string> values)
        {



            return "";
        }
    }
}
