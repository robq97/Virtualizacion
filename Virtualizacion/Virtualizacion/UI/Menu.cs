using System;
using System.Windows.Forms;
using Virtualizacion.Logica;

namespace Virtualizacion.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next_form = new Login();
            next_form.Closed += (s, args) => this.Close();
            next_form.Show();

            Memoria.usuario_actual = null;
        }

        private void button_ver_contactos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next_form = new VerContactos();
            next_form.Closed += (s, args) => this.Close();
            next_form.Show();
        }

        private void button_crear_nuevo_contacto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next_form = new CrearContacto();
            next_form.Closed += (s, args) => this.Close();
            next_form.Show();
        }
    }
}
