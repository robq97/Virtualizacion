using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Virtualizacion.Logica
{
    public class SQL
    {

        public string SQLConnectionString =
            ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        public void SetSQLConnectionString(string DataSource
            , string InitialCatalog
            , string User
            , string Password)
        {
            this.SQLConnectionString =
                string.Format("Data Source={0};" +
                "Initial Catalog={1};" +
                "User id={2};" +
                "Password={3};", DataSource, InitialCatalog, User, Password);
            Console.WriteLine("SQL connection overwritten.");
            Console.WriteLine(this.SQLConnectionString);
        }

        public void Query(string query)
        {
            SqlConnection connection = new SqlConnection(this.SQLConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = connection;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataSet Fetch(string query)
        {
            SqlConnection connection = new SqlConnection(this.SQLConnectionString);
            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dadapter.Fill(ds);
            connection.Close();
            return ds;
        }

        public bool CheckConnection()
        {
            SqlConnection connection = new SqlConnection(this.SQLConnectionString);
            SqlDataAdapter dadapter = new SqlDataAdapter("SELECT 1", connection);
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            
        }
    }
}
