using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Virtualizacion.Logica
{
    public class SQL
    {

        string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        public void Query(string query)
        {
            SqlConnection connection = new SqlConnection(this.conn);

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
            SqlConnection connection = new SqlConnection(this.conn);
            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dadapter.Fill(ds);
            connection.Close();
            return ds;
        }
    }
}
