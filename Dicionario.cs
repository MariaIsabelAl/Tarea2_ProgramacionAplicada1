using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea2_ProgramacionAplicada1
{
    class Dicionario
    {
        string palabra = " ";
        public void correr()
        {
            Hashtable tabla = new Hashtable();

            tabla.Add("Mancuerna", "Pieza de equipamiento utilizada en el entrenamiento con pesas, es un tipo de peso libre.");
            tabla.Add("Materia", "Todo lo que posee mata y ocupa un lugar en el espacio.");
            tabla.Add("Cedula", "Documento que contiene datos personales.");

            Console.WriteLine("1. Cedula\n2. Mancuerna\n3. Materia");
            Console.WriteLine("Esriba la palabra que a buscar: ");
            palabra = Console.ReadLine();


            Console.WriteLine("\n" + tabla[palabra]);

        }
    }
}
