using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Virtualizacion.Logica;

namespace Virtualizacion.UI
{
    public partial class EstablecerConexionSQL : Form
    {
        public EstablecerConexionSQL()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private bool conexion_personalizada_probada_y_exitosa = false;
        private bool conexion_predeterminada_actualizada = false;

        private void button_usar_bd_default_pregunta_Click(object sender, EventArgs e)
        {
            Ejecutar.MESSAGEBOX("Base de datos predeterminada:\r\n" +
                "\r\n" +
                "Base de datos en Azure.\r\n" +
                "Host: grupo2-ulacit.database.windows.net\r\n" +
                "Base de datos: DB_VIRTUALIZACION"
                , "Default DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_usar_base_de_datos_predeterminada_Click(object sender, EventArgs e)
        {
            if (!conexion_predeterminada_actualizada)
            {
                abrir_menu_login();
            }
            else
            {
                Ejecutar.MESSAGEBOX("Se a cambiado la conexion predeterminada.\r\n" +
                    "Reinicie la aplicación para utilizarla.","Conexión personalizada cambiada",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void abrir_menu_login()
        {
            this.Hide();
            var next_form = new Login();
            next_form.Closed += (s, args) => this.Close();
            next_form.Show();
        }

        private void button_probar_conexion_Click(object sender, EventArgs e)
        {
            conexion_predeterminada_actualizada = true;
            establecer_db_host_personalizado();
            bool estado_conexion = Memoria.sql.CheckConnection();
            if (estado_conexion)
            {
                this.conexion_personalizada_probada_y_exitosa = true;
                Ejecutar.MESSAGEBOX("¡Conexión exitosa!", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Ejecutar.MESSAGEBOX("No ha sido posible establecer una conexión con el servidor."
                    , "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void establecer_db_host_personalizado()
        {
            string host = this.textBox_host_base_de_datos.Text;
            string db = this.textBox_nombre_base_de_datos.Text;
            string user = this.textBox_usuario_base_de_datos.Text;
            string pass = this.textBox_contrasenia_base_de_datos.Text;

            Memoria.sql.SetSQLConnectionString(host, db, user, pass);
        }

        private void button_usar_conexion_Click(object sender, EventArgs e)
        {
            conexion_predeterminada_actualizada = true;
            if (conexion_personalizada_probada_y_exitosa)
            {
                abrir_menu_login();
            }
            else
            {
                Ejecutar.MESSAGEBOX("Debe primero establecer una conexion exitosa"
                    , "Conexion personalizada"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
        }
    }
}
