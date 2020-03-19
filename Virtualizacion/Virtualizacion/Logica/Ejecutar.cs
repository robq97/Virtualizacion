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
    }
}
