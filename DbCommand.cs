using System;

namespace DbConnectionApp
{
    public class DbCommand
    {
        public string Instruction { get; set; }
        public DbConnection DbCon;
        public DbCommand (DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null || instruction == null)
            {
                throw new ArgumentNullException("dbConnection or instruction cannot be null");
            }
            else
            {
                this.Instruction = instruction;
                this.DbCon = dbConnection;
            }
        }
        public void Execute()
        {
            DbCon.Open(); 
            Console.WriteLine("Run the {0} connection", DbCon.ConnectionString);
            DbCon.Close();

        }

    }
}
