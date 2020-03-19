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
            var next_form = new Menu();
            next_form.Closed += (s, args) => this.Close();
            next_form.Show();
        }
    }
}

