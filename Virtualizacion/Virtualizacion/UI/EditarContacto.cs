using System;
using System.Windows.Forms;
using Virtualizacion.Logica;
using Virtualizacion.Objetos;

namespace Virtualizacion.UI
{
    public partial class EditarContacto : Form
    {

        private Contacto contacto_a_editar;

        public EditarContacto(Contacto contacto_a_editar)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.contacto_a_editar = contacto_a_editar;
            establecer_espacios();
        }

        private void establecer_espacios()
        {
            string nombre = this.contacto_a_editar.Nombre;
            string apellido = this.contacto_a_editar.Apellido;
            string telefono = this.contacto_a_editar.Telefono;
            string correo = this.contacto_a_editar.Correo;

            this.textBox_nombre.Text = nombre;
            this.textBox_apellido.Text = apellido;
            this.textBox_telefono.Text = telefono;
            this.textBox_correo.Text = correo;
        }

        private void button_guardar_contacto_Click(object sender, EventArgs e)
        {
            bool espacios_espacios_llenos = estan_todos_los_espacios_llenos();
            if (espacios_espacios_llenos)
            {
                Contacto contacto_editado = contruir_contacto_editado();
                guardar_contacto_editado(contacto_editado);
                string mensaje = string.Format("Contacto {0} editado", this.contacto_a_editar.Nombre);
                Ejecutar.MESSAGEBOX(mensaje, "Contacto editado"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                volver_al_menu_ver_contactos();
            }
        }

        private void guardar_contacto_editado(Contacto contacto_editado)
        {
            Memoria.sql.guardar_contacto_editado(contacto_editado);
        }

        private Contacto contruir_contacto_editado()
        {
            Contacto contacto_editado = new Contacto(this.contacto_a_editar.ID_Contacto
                , this.textBox_nombre.Text
                , this.textBox_apellido.Text
                , this.textBox_telefono.Text
                , this.textBox_correo.Text);
            return contacto_editado;
        }

        private bool estan_todos_los_espacios_llenos()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox_nombre.Text) &&
                !string.IsNullOrWhiteSpace(this.textBox_apellido.Text) &&
                !string.IsNullOrWhiteSpace(this.textBox_telefono.Text) &&
                !string.IsNullOrWhiteSpace(this.textBox_correo.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            volver_al_menu_ver_contactos();
        }

        private void volver_al_menu_ver_contactos()
        {
            this.Hide();
            var next_form = new VerContactos();
            next_form.Closed += (s, args) => this.Close();
            next_form.Show();
        }
    }
}
