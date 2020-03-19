using System.Collections.Generic;
using Virtualizacion.Objetos;

namespace Virtualizacion.Logica
{
    public class Memoria
    {
        //Listas de entidades.
        public static List<Contacto> lista_contactos = new List<Contacto>();
        public static List<Usuario> lista_usuarios = new List<Usuario>();
        public static List<ReferenciaUsuario_X_Contacto> lista_referencias_usuario_contacto = 
            new List<ReferenciaUsuario_X_Contacto>();

        //Usuario actual. Instancia del usuario que se encuentra utilizando el programa actualmente.
        public static Usuario usuario_actual = null;

        //Instancia de SQL para realizar consultas en cualquier lugar del programa.
        public static SQLController sql = new SQLController();
    }
}
