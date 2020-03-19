using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualizacion.Objetos
{
    public class Usuario
    {

        public int ID_Usuario;
        public string Nombre;
        public string Apellido;
        public string Nombre_Usuario;
        public string Clave;

        public Usuario(int iD_Usuario
            , string nombre
            , string apellido
            , string nombre_Usuario
            , string clave)
        {
            this.ID_Usuario = iD_Usuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nombre_Usuario = nombre_Usuario;
            this.Clave = clave;
        }

        public override string ToString()
        {
            return this.ID_Usuario + ", " + this.Nombre + ", " + this.Apellido + ", " + this.Nombre_Usuario + ", " + this.Clave;
        }
    }
}
