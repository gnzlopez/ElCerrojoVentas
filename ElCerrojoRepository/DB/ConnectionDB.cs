using Microsoft.Extensions.Configuration;

namespace ElCerrojoRepository.DB
{
    public static class ConnectionDB
    {
        //private readonly IConfiguration _configuration;
        //private readonly string _sqlString;

        //public ConnectionDB(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        public static string GetConnection(string dbName)
        {
            string DBPath = string.Empty;

            if (string.IsNullOrEmpty(dbName))
            {
                return null;
            }

            //if (string.IsNullOrEmpty(_sqlString))
            //{
                DBPath = Environment.CurrentDirectory;
            //}
            //else
            //{
            //    DBPath = _sqlString;
            //}
            DBPath = Path.Combine(DBPath, dbName);

            return DBPath;
        }

    }
}
