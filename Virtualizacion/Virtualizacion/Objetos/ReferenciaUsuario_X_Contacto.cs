namespace Virtualizacion.Objetos
{
    public class ReferenciaUsuario_X_Contacto
    {
        public int ID_Usuario, ID_Contacto, ID_Registro_BaseDeDatos;

        public ReferenciaUsuario_X_Contacto(int iD_Usuario, int iD_Contacto, int iD_Registro_BaseDeDatos)
        {
            ID_Usuario = iD_Usuario;
            ID_Contacto = iD_Contacto;
            ID_Registro_BaseDeDatos = iD_Registro_BaseDeDatos;
        }

        public override string ToString()
        {
            return "ID Usuario: " + ID_Usuario + ", ID Contacto: " + ID_Contacto + ", ID Registro en base de datos: " + ID_Registro_BaseDeDatos;
        }
    }
}
