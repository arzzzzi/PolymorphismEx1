using System;

namespace PolymorphismEx1
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        //private TimeSpan Timeout;
        protected bool isConnected;

        public DbConnection(string connString)
        {
            if (String.IsNullOrWhiteSpace(connString))
                throw new ArgumentNullException("A connection string is required to obtain a DB Connection");
            else
                ConnectionString = connString;
        }

        public abstract void Open();

        public abstract void Close();

    }
}