using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualizacion.Objetos
{
    public class Contacto
    {

        public int ID_Contacto;
        public string Nombre, Apellido, Telefono, Correo;

        public Contacto(int iD_Contacto, string nombre, string apellido, string telefono, string correo)
        {
            ID_Contacto = iD_Contacto;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
        }

        public override string ToString()
        {
            return ID_Contacto + ", " + Nombre + ", " + Apellido + ", " + Telefono + ", " + Correo;
        }
    }
}
