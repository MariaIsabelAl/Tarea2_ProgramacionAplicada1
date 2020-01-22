using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_ProgramacionAplicada1
{
    class Cadena
    {
        public void cadena()
        {
            int num;
            Console.WriteLine("Dame un numero 0 al 9");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Cero");
                    break;
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    Console.WriteLine("Seis");
                    break;
                case 7:
                    Console.WriteLine("Siete");
                    break;
                case 8:
                    Console.WriteLine("Ocho");
                    break;
                case 9:
                    Console.WriteLine("Nueve");
                    break;
                default:
                    Console.WriteLine("Numero no valido");
                    break;
            }
        }
    }
}
