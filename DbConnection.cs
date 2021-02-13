using System;

namespace DbConnectionApp
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string conString)
        {
            if (conString == null)
            {
                throw new ArgumentNullException("Connection string cannot be null");
            }
            else
            {
                ConnectionString = conString;
            }
        }
        public abstract void Open();
        public abstract void Close();
    }
}
