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
        }
    }
}
