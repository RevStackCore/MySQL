using System;
namespace RevStackCore.MySQL
{
    public class MySQLDbContext
    {
        public string ConnectionString { get; }
        public MySQLDbContext(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
