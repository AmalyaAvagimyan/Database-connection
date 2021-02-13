namespace DbConnectionApp
{
   class Program
    {
        static void Main(string[] args)
        {
            var sqlCon = new SqlConnection("sql");
            var oracleCon = new OracleConnection("oracle");

            var sqlCommand = new DbCommand(sqlCon, "Sql instruction");
            sqlCommand.Execute();

            var oracleCommand = new DbCommand(oracleCon, "Oracle instruction");
            oracleCommand.Execute();          
        }
    }
}
