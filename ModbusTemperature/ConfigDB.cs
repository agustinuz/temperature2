using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ModbusTemperature
{
    internal class ConfigDB
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["flex"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
    
};
