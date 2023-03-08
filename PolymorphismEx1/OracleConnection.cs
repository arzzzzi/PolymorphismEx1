using System;
using System.Data.Common;

namespace PolymorphismEx1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string oracleConnectionString)
            : base(oracleConnectionString)
        {
            Console.WriteLine("Now using Oracle connection...");
        }
        public override void Open()
        {
            if (isConnected)
                throw new InvalidOperationException("The Oracle DB is already open");

            isConnected = true;
            Console.WriteLine($"Oracle Connection has been opened using \"{ConnectionString}\"");
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