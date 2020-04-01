using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Virtualizacion.Logica;
using Virtualizacion.Objetos;

namespace Virtualizacion.UI
{
    public partial class VerContactos : Form
    {
        public VerContactos()
        {
            InitializeComponent();
            ajustes();
        }

        private void ajustes()
        {
            this.CenterToScreen();
            Ejecutar.cargar_lista_de_contactos_en_memoria();
            Ejecutar.cargar_referencias_de_usuario_x_contacto_en_memoria();
            cargar_contactos_en_lista();
        }

        private void cargar_contactos_en_lista()
        {
            List<Contacto> lista_contactos_del_usuario = new List<Contacto>();
            List<int> ids_de_contactos_asociados_a_usuario =
                Ejecutar.retornar_ids_de_contactos_pertenecientes_a_usuario();


            for (int i = 0; i < Memoria.lista_contactos.Count; i++)
            {
                for (int j = 0; j < ids_de_contactos_asociados_a_usuario.Count; j++)
                {
                    if (Memoria.lista_contactos[i].ID_Contacto == ids_de_contactos_asociados_a_usuario[j])
                    {
                        lista_contactos_del_usuario.Add(Memoria.lista_contactos[i]);
                        break;
                    }
                }
            }

            for (int i = 0; i < lista_contactos_del_usuario.Count; i++)
            {
                this.listBox_lista_contactos.Items.Add(lista_contactos_del_usuario[i]);
            }
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next_form = new Menú();
            next_form.Closed += (s, args) => this.Close();
            next_form.Show();
        }

        private void button_boton_borrar_Click(object sender, EventArgs e)
        {
            Contacto contacto_seleccionado = this.listBox_lista_contactos.SelectedItem as Contacto;
            if (contacto_seleccionado != null)
            {
                Contacto contacto_temporal;
                for (int i = 0; i < this.listBox_lista_contactos.Items.Count; i++)
                {
                    contacto_temporal = listBox_lista_contactos.Items[i] as Contacto;
                    if (contacto_temporal.ID_Contacto == contacto_seleccionado.ID_Contacto)
                    {
                        listBox_lista_contactos.Items.RemoveAt(i);
                        Memoria.sql.eliminar_relacion_usuario_x_contacto(contacto_seleccionado.ID_Contacto,
                            Memoria.usuario_actual.ID_Usuario);
                        Memoria.sql.eliminar_contacto_de_base_de_datos(contacto_seleccionado.ID_Contacto);
                    }
                }
            }
        }

        private void button_boton_editar_Click(object sender, EventArgs e)
        {
            Contacto contacto_seleccionado = this.listBox_lista_contactos.SelectedItem as Contacto;
            if(contacto_seleccionado != null)
            {
                this.Hide();
                var next_form = new EditarContacto(contacto_seleccionado);
                next_form.Closed += (s, args) => this.Close();
                next_form.Show();
            }
        }
    }
}

