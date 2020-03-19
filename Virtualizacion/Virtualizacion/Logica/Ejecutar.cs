using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Virtualizacion.UI;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Virtualizacion.Logica
{
    public class Ejecutar
    {
        public void run()
        {
            abrir_ventana_login();
        }

        private void abrir_ventana_login()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static void MESSAGEBOX(string message_content,
            string title,
            MessageBoxButtons mbButtons,
            MessageBoxIcon mbIcon)
        {
            MessageBox.Show(message_content, title, mbButtons, mbIcon);
        }

        public static void cargar_referencias_de_usuario_x_contacto_en_memoria()
        {
            Memoria.lista_referencias_usuario_contacto = null;
            Memoria.lista_referencias_usuario_contacto = Memoria.sql.cargar_referencias_de_usuario_y_contacto();
            Console.WriteLine("Referencias usuario x contacto cargadas.");
        }

        public static void cargar_lista_de_contactos_en_memoria()
        {
            Memoria.lista_contactos = null;
            Memoria.lista_contactos = Memoria.sql.cargar_contactos_de_la_base_de_datos();
            Console.WriteLine("Contactos cargados.");
        }

        internal static List<int> retornar_ids_de_contactos_pertenecientes_a_usuario()
        {
            int id_usuario = Memoria.usuario_actual.ID_Usuario;
            List<int> ids_de_contactos_asociados_a_usuario = new List<int>();

            for (int i = 0; i < Memoria.lista_contactos.Count; i++)
            {
                int id_contacto = Memoria.lista_contactos[i].ID_Contacto;
                for (int j = 0; j < Memoria.lista_referencias_usuario_contacto.Count; j++)
                {
                    if(Memoria.lista_referencias_usuario_contacto[j].ID_Usuario == id_usuario&&
                        Memoria.lista_referencias_usuario_contacto[j].ID_Contacto == id_contacto)
                    {
                        ids_de_contactos_asociados_a_usuario.Add(id_contacto);
                        break;
                    }
                }
            }
            return ids_de_contactos_asociados_a_usuario;
        }
    }
}
