using System;
using System.Data.Common;

namespace PolymorphismEx1
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string sqlConnectionString)
            : base(sqlConnectionString)
        {
            Console.WriteLine("Now using SQL connection...");
        }

        public override void Open()
        {
            if (isConnected)
                throw new InvalidOperationException("The DB you are trying to open is already open.");

            isConnected = true;
            Console.WriteLine($"SQL Connection has been opened using \"{ConnectionString}\"");
        }

        public override void Close()
        {
            if (isConnected == false)
                throw new InvalidOperationException("the Oracle DB was not opened. Please open before trying to close.");

            isConnected = false;
            Console.WriteLine("Oracle Connection has been Closed");
        }
    }
}