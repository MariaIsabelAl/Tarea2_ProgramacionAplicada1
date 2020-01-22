using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_ProgramacionAplicada1
{
    class Factorial
    {
        public void calcularfactorial()
        {
            int num;
            Console.WriteLine("Dijete un numero");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El factorial de {0} es {1}", num, factorial(num));
        }

        public int factorial(int num)
        {
            if (num == 0 || num == 1)
                return num;
            return num*factorial(num - 1);
        }
    }
}
