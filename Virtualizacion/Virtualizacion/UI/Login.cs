using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Virtualizacion.Logica;
using Virtualizacion.Objetos;

namespace Virtualizacion.UI
{
    public partial class Login : Form
    {

        private List<Usuario> lista_usuarios_temporal = new List<Usuario>();

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button_iniciar_sesion_Click(object sender, EventArgs e)
        {
            log_in_method_tree();
        }

        private void log_in_method_tree()
        {
            string nombre_de_usuario = this.textBox_usuario.Text;
            string contrasenia = this.textBox_contrasenia.Text;
            if (!string.IsNullOrWhiteSpace(nombre_de_usuario) &&
                !string.IsNullOrWhiteSpace(contrasenia))
            {
                this.lista_usuarios_temporal = Memoria.sql.cargar_todos_los_usuarios_en_base_de_datos();
                for (int i = 0; i < lista_usuarios_temporal.Count; i++)
                {
                    if (string.Equals(lista_usuarios_temporal[i].Nombre_Usuario, nombre_de_usuario)&&
                        string.Equals(lista_usuarios_temporal[i].Clave,contrasenia))
                    {
                        Memoria.usuario_actual = lista_usuarios_temporal[i];
                        break;
                    }
                }
            }
            if (Memoria.usuario_actual != null)
            {
                abrir_ventana_menu_principal();
            }
            else
            {
                Ejecutar.MESSAGEBOX("Usuario o contraseña incorrectos",
                    "Credenciales incorrectos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void abrir_ventana_menu_principal()
        {
            this.Hide();
            var next_form = new Menu();
            next_form.Closed += (s, args) => this.Close();
            next_form.Show();
        }

        private void textBox_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                log_in_method_tree();
            }
        }

        private void textBox_contrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                log_in_method_tree();
            }
        }
    }
}
