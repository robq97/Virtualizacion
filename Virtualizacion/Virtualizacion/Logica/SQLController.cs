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

        public List<Contacto> cargar_contactos_de_la_base_de_datos()
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

        internal void guardar_contacto_editado(Contacto contacto_editado)
        {
            string query = string.Format(@"UPDATE Contacto
                                    SET Nombre = '{0}'
                                        , Apellido = '{1}'
                                        , Telefono = '{2}'
                                        , Correo = '{3}'
                                   WHERE ID_Contacto = {4};"
                                    , contacto_editado.Nombre
                                    , contacto_editado.Apellido
                                    , contacto_editado.Telefono
                                    , contacto_editado.Correo
                                    , contacto_editado.ID_Contacto);
            Memoria.sql.Query(query);
            Console.WriteLine(string.Format("Contacto {0} editado satisfactoriamente.",contacto_editado.Nombre + " ID: " + contacto_editado.ID_Contacto));
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
                    new ReferenciaUsuario_X_Contacto(ID_Usuario, ID_Contacto, ID_Registro);
                Console.WriteLine(ru_x_c);
                lista_temporal.Add(ru_x_c);
            }
            return lista_temporal;
        }

        public void eliminar_contacto_de_base_de_datos(int iD_Contacto)
        {
            string query = @"DELETE FROM Contacto WHERE ID_Contacto = " + iD_Contacto + ";";
            Console.WriteLine("Query: " + query);
            Query(query);
            Console.WriteLine(string.Format("Contacto: {0} eliminado de la base de datos.", iD_Contacto));
        }

        public void eliminar_relacion_usuario_x_contacto(int iD_Contacto, int iD_Usuario)
        {
            string query = String.Format(@"DELETE FROM Usuario_x_Contacto
                            WHERE ID_Usuario = {0} AND ID_Contacto = {1};"
                                , iD_Usuario
                                , iD_Contacto);
            Console.WriteLine("Query: " + query);
            Query(query);
            Console.WriteLine(string.Format("Relacion Usuario: {0} y Contacto: {1} eliminado", iD_Usuario, iD_Contacto));
        }

        public void guardar_nuevo_contacto(Contacto contacto_a_guardar, int id_usuario)
        {
            string query_guardar_contacto = @"INSERT INTO Contacto (Nombre, Apellido, Telefono, Correo)
                            VALUES ('" + contacto_a_guardar.Nombre + "'," +
                            " '" + contacto_a_guardar.Apellido + "'," +
                            " '" + contacto_a_guardar.Telefono + "'," +
                            "'" + contacto_a_guardar.Correo + "');";

            Memoria.sql.Query(query_guardar_contacto);
            Ejecutar.cargar_lista_de_contactos_en_memoria();

            int id_contacto_base_de_datos = 0;
            for (int i = 0; i < Memoria.lista_contactos.Count; i++)
            {
                if (Memoria.lista_contactos[i].Nombre == contacto_a_guardar.Nombre &&
                    Memoria.lista_contactos[i].Apellido == contacto_a_guardar.Apellido &&
                    Memoria.lista_contactos[i].Telefono == contacto_a_guardar.Telefono &&
                    Memoria.lista_contactos[i].Correo == contacto_a_guardar.Correo)
                {
                    id_contacto_base_de_datos = Memoria.lista_contactos[i].ID_Contacto;
                    break;
                }
            }

            string query_referencia_usuario_x_contacto = @"INSERT INTO Usuario_X_Contacto (ID_Usuario, ID_Contacto)
                                VALUES ('" + id_usuario + "', '" + id_contacto_base_de_datos + "');";

            Memoria.sql.Query(query_referencia_usuario_x_contacto);

        }

    }
}
