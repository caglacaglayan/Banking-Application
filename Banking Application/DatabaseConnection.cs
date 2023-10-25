using System;
using System.Data.SqlClient;
using System.Data;

namespace CG_Bank
{
    public class DatabaseConnection
    {

        public string connectionString;
        public SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public DatabaseConnection()
        {
            connectionString = "Data Source=DESKTOP-99KSBNG;Initial Catalog=CG_Bank;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public SqlDataReader DataReader(string query)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(query, connection);
            var execute = cmd.ExecuteReader();

            return execute;
        }

        public bool State()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void SqlProcess(string query) // QUERY
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public DataTable GridSqlProcess(string query) // QUERY 2
        {
            OpenConnection();
            SqlCommand komut = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            CloseConnection();

            return dt;
        }

    }
}