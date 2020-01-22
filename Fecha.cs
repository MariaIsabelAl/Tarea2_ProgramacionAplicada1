using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_ProgramacionAplicada1
{
    class Fecha
    {
        string forma;

        public void formato()
        {
            forma = string.Format("Fecha:{0: h:m tt d / M / yyy}", DateTime.Now);
            Console.WriteLine(forma);
        }
    }
}
