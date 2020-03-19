using System;
using System.Collections.Generic;
using System.Data;
using Virtualizacion.Objetos;

namespace Virtualizacion.Logica
{
    public class SQLController : SQL
    {

        public List<Usuario> cargar_todos_los_usuarios_en_base_de_datos()
        {
            string query = "SELECT * FROM Usuario";
            DataSet ds_usuarios = Fetch(query);
            List<Usuario> lista_temporal = new List<Usuario>();
            for (int i = 0; i < ds_usuarios.Tables[0].Rows.Count; i++)
            {
                int ID_Usuario = Convert.ToInt32(ds_usuarios.Tables[0].Rows[i]["ID_Usuario"]);
                string Nombre = ds_usuarios.Tables[0].Rows[i]["Nombre"].ToString();
                string Apellido = ds_usuarios.Tables[0].Rows[i]["Apellido"].ToString();
                string Nombre_Usuario = ds_usuarios.Tables[0].Rows[i]["Nombre_Usuario"].ToString();
                string Clave = ds_usuarios.Tables[0].Rows[i]["Clave"].ToString();
                Usuario u = new Usuario(ID_Usuario, Nombre, Apellido, Nombre_Usuario, Clave);
                Console.WriteLine(u);
                lista_temporal.Add(u);
            }
            return lista_temporal;
        }

        public List<Contacto> cargar_contactos_de_un_usuario()
        {
            string query = "SELECT * FROM Contacto";
            DataSet ds_contactos = Fetch(query);
            List<Contacto> lista_temporal = new List<Contacto>();
            for (int i = 0; i < ds_contactos.Tables[0].Rows.Count; i++)
            {
                int ID_Contacto = Convert.ToInt32(ds_contactos.Tables[0].Rows[i]["ID_Contacto"]);
                string nombre = ds_contactos.Tables[0].Rows[i]["Nombre"].ToString();
                string apellido = ds_contactos.Tables[0].Rows[i]["Apellido"].ToString();
                string telefono = ds_contactos.Tables[0].Rows[i]["Telefono"].ToString();
                string correo = ds_contactos.Tables[0].Rows[i]["Correo"].ToString();
                Contacto c = new Contacto(ID_Contacto, nombre, apellido, telefono, correo);
                Console.WriteLine(c);
                lista_temporal.Add(c);
            }
            return lista_temporal;
        }

        public List<ReferenciaUsuario_X_Contacto> cargar_referencias_de_usuario_y_contacto()
        {
            string query = "SELECT * FROM Usuario_X_Contacto";
            DataSet ds = Fetch(query);
            List<ReferenciaUsuario_X_Contacto> lista_temporal = 
                new List<ReferenciaUsuario_X_Contacto>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int ID_Contacto = Convert.ToInt32(ds.Tables[0].Rows[i]["ID_Contacto"]);
                int ID_Usuario = Convert.ToInt32(ds.Tables[0].Rows[i]["ID_Usuario"]);
                int ID_Registro = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"]);
                ReferenciaUsuario_X_Contacto ru_x_c = 
                    new ReferenciaUsuario_X_Contacto(ID_Usuario,ID_Contacto,ID_Registro);
                Console.WriteLine(ru_x_c);
                lista_temporal.Add(ru_x_c);
            }
            return lista_temporal;
        }

    }
}
