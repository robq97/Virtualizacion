using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Virtualizacion.Logica;
using Virtualizacion.Objetos;

namespace Virtualizacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Ejecutar e = new Ejecutar();
            e.run();

            //Contacto c = new Contacto(1,"nombre","ap","tel","correo");
            //Console.WriteLine(c);

            /* Memoria.sql.Query("INSERT INTO Usuario " +
                 "(Nombre, Apellido, Nombre_Usuario, Clave)" +
                 "VALUES " +
                 "('Josue','Mora','JMV','root');");*/

            //DataSet ds = Memoria.sql.Fetch("SELECT * FROM Usuario");
            //for (int i = 0; i < ds.Tables.Count; i++)
            //{
            //    Console.WriteLine(ds.Tables[0].Rows[3]["Nombre"]);
            //}

        }
    }
}
