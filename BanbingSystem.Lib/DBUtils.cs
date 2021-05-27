using MySql.Data.MySqlClient;

namespace BankingSystem.Lib
{
    public class DBUtils
    {

        private static string host = "remotemysql.com";
        private static string database = "HEtUgcXWv8";
        private static string userid = "HEtUgcXWv8";
        private static string password = "k4Aj1Xgz6C";

        public static MySqlConnection GetConnection()
        {

            string connString = "Server=" + host + ";Database=" + database + ";User Id=" + userid + ";password=" + password + "; Allow User Variables=True";

            return new MySqlConnection(connString);

        }

        public static bool ExecQuery(string query)
        {

            MySqlConnection connection = DBUtils.GetConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            bool hasRows = reader.HasRows;

            connection.Close();

            return hasRows;

        }

    }

}
