using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading;

namespace TradingCompany.DAL.Core
{
    //Consider Copypast
    public sealed class ConnectionManager
    {
        //private const string CONNECTION_STRING = "server=127.0.0.1;uid=p31;pwd=Pa$$Pmp31;database=pmp31";
        //
        private static volatile ConnectionManager instance = null;
        private DbProviderFactory factory = null;
        //
        private string connectionString;
        private IDictionary<int, DbConnection> connections;

        private ConnectionManager(string connectionString)
        {
            this.factory = DbProviderFactories.GetFactory(ConfigurationManager.AppSettings["provider"]);
            this.connectionString = connectionString;
            connections = new Dictionary<int, DbConnection>();
        }

        public static ConnectionManager Get()
        {
            return Get(null);
        }

        public static ConnectionManager Get(string connectionString)
        {
            if (instance == null)
            {
                lock (typeof(ConnectionManager))
                {
                    if (instance == null)
                    {
                        if (connectionString == null)
                        {
                            //connectionString = CONNECTION_STRING;
                            //TODO
                            connectionString = ConfigurationManager.ConnectionStrings["TradingCompany"].ConnectionString; ;
                        }
                        instance = new ConnectionManager(connectionString);
                    }
                }
            }
            return instance;
        }

        public static void CloseConnections()
        {
            List<int> connectionsToClose = new List<int>();
            DbConnection connection;

            foreach (KeyValuePair<int, DbConnection> kvp in Get().connections)
            {
                connection = Get().connections[kvp.Key];

                if ((connection != null))
                {
                    connectionsToClose.Add(kvp.Key);
                }
            }
            foreach (int key in connectionsToClose)
            {
                //connection = Get().connections[key];
                Get().connections.Remove(key);
            }
        }

        public IDbConnection GetConnection()
        {
            //MySqlConnection connection = connections[Thread.CurrentThread.ManagedThreadId];
            DbConnection connection;
            connections.TryGetValue(Thread.CurrentThread.ManagedThreadId, out connection);
            if (connection == null)
            {
                connection = factory.CreateConnection();
                connection.ConnectionString = connectionString;
                //connection = new DbConnection(connectionString);
                connections.Add(Thread.CurrentThread.ManagedThreadId, connection);
            }
            return connection;
        }
    }
}
