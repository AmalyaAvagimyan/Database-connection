using System;

namespace DbConnectionApp
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string conString)
            : base(conString)
        {

        }
        public override void Open()
        {
           Console.WriteLine("Open oracle connection");
        }
        public override void Close()
        {
            Console.WriteLine("Close oracle connection");
        }
    }
}
