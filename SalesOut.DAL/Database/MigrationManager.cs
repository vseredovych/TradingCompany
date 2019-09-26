using SalesOut.DAL.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOut.DAL.Database
{
    public class MigrationManager
    {
        DbManager dbManager = new DbManager();

        public bool CreateTables()
        {
            string path = System.IO.Path.GetFullPath(@"..\..\..\SalesOut.DAL\Database\create_tables.sql");
            string script = File.ReadAllText(path);
            dbManager.ExecuteNonQuery(script);

            return true;
        }
        public bool DropTables()
        {
            string path = System.IO.Path.GetFullPath(@"..\..\..\SalesOut.DAL\Database\drop_tables.sql");
            string script = File.ReadAllText(path);
            dbManager.ExecuteNonQuery(script);

            return true;
        }

    }
}
