using System;

namespace DbConnectionApp
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection (string conString)
            : base(conString)
        {
          
        }
        public override void Open ()
        {
            Console.WriteLine("Open sql connection");
        }
        public override void Close()
        {
            Console.WriteLine("Close sql connection");
        }
    }
}
