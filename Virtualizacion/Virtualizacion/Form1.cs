using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtualizacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create a connection calling the App.config
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            //The query to use
            string query = "SELECT * FROM [dbo].[Usuario]";
            SqlConnection connection = new SqlConnection(conn);
            //Create a Data Adapter
            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);
            //Create the dataset
            DataSet ds = new DataSet();
            //Open the connection
            connection.Open();
            //Fill the DatSet with the adapter information
            dadapter.Fill(ds, "usuarios");
            connection.Close();
            //Bind the datagridview with the data set
            dgv.DataSource = ds;
            dgv.DataMember = "usuarios";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
