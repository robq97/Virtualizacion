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
using Virtualizacion.Objetos;

namespace Virtualizacion.UI
{
    public partial class CrearContacto : Form
    {
        public CrearContacto()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button_guardar_contacto_Click(object sender, EventArgs e)
        {
            guardar_nuevo_contacto_method_tree();
        }

        private void guardar_nuevo_contacto_method_tree()
        {
            bool todos_los_espacios_llenos = estan_todos_los_espacios_llenos_pregunta();
            if (todos_los_espacios_llenos)
            {
                string nombre = this.textBox_nombre.Text;
                string apellido = this.textBox_apellido.Text;
                string telefono = this.textBox_telefono.Text;
                string correo = this.textBox_correo.Text;
                Contacto contacto_nuevo = new Contacto(nombre, apellido, telefono, correo);
                Ejecutar.cargar_lista_de_contactos_en_memoria();
                Memoria.sql.guardar_nuevo_contacto(contacto_nuevo,Memoria.usuario_actual.ID_Usuario);
                Ejecutar.MESSAGEBOX("Usuario guardado correctamente","Exito",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                limpiar_text_boxes();
            }
            else
            {
                Ejecutar.MESSAGEBOX("Debe rellenar todos los espacios","Informacion incompleta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void limpiar_text_boxes()
        {
            this.textBox_nombre.Text = "";
            this.textBox_apellido.Text = "";
            this.textBox_telefono.Text = "";
            this.textBox_correo.Text = "";
        }

        private bool estan_todos_los_espacios_llenos_pregunta()
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
            this.Hide();
            var next_form = new Menú();
            next_form.Closed += (s, args) => this.Close();
            next_form.Show();
        }
    }
}
