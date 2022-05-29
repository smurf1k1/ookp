using System.Data.SqlClient;

namespace lab5.Data
{
    public class DatabaseConnection
    {
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-CSMF3T7;Initial Catalog=Sklad;Integrated Security=True;");
        }
    }
}
