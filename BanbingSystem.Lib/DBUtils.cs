using MySql.Data.MySqlClient;

namespace Lib
{
    public class DBUtils
    {

        private static string host = "remotemysql.com";
        private static string database = "HEtUgcXWv8";
        private static string userid = "HEtUgcXWv8";
        private static string password = "k4Aj1Xgz6C";

        public static MySqlConnection getConnection()
        {

            string connString = "Server=" + host + ";Database=" + database + ";User Id=" + userid + ";password=" + password + "; Allow User Variables=True";

            return new MySqlConnection(connString);

        }

        public static void execQuery(string query)
        {

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.ExecuteNonQuery();

            connection.Close();

        }

    }

}
