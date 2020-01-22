using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_ProgramacionAplicada1
{
    class Ordenar
    {
        string cad, cad2;
        int com;

        public void orden()
        {
            Console.WriteLine("Escriba la cadena 1");
            cad = Console.ReadLine();
            Console.WriteLine("Escriba la cadena 2");
            cad2 = Console.ReadLine();

            com = String.Compare(cad, cad2);

            if (com < 0)
            {
                Console.WriteLine("\n" + cad + "\n" + cad2);
            }
            else
            {
                Console.WriteLine("\n" + cad2 + "\n" + cad);
            }
        }
    }
}
