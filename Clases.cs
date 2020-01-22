using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea2_ProgramacionAplicada1
{
    class Clases
    {
        int cantSalon, cantAlum, x, y;
        float menor = 9999, mayor = 0, acu = 0, promedio;

        public void colegio()
        {
            x = 0; y = 0;
            Console.WriteLine("Digite la cantidad de salon: ");
            cantSalon = Convert.ToInt32(Console.ReadLine());

            float[][] cali = new float[cantSalon][];

            for (x = 0; x < cantSalon; x++)
            {
                Console.WriteLine("Digite la cantidad de alumno del salon[" + (x + 1) + "]: ");
                cantAlum = Convert.ToInt32(Console.ReadLine());

                cali[x] = new float[cantAlum];

            }

            for (x = 0; x < cantSalon; x++)
            {
                Console.WriteLine("Salon [" + (x + 1) + "]");
                for (y = 0; y < cali[x].GetLength(0); y++)
                {
                    Console.WriteLine("Digite la calificacion[" + (y + 1) + "]");
                    cali[x][y] = Convert.ToSingle(Console.ReadLine());
                    if (cali[x][y] > mayor)
                        mayor = cali[x][y];
                    if (cali[x][y] < menor)
                        menor = cali[x][y];
                }
            }

            Console.WriteLine("\t\tImpresion de datos");
            for (x = 0; x < cantSalon; x++)
            {
                Console.WriteLine("Salon [" + (x + 1) + "]");
                for (y = 0; y < cali[x].GetLength(0); y++)
                    Console.WriteLine("Calificacion del alumno [" + (y + 1) + "]:" + cali[x][y]);
                Console.WriteLine("\tPromedio de calificaciones: " + calcularpromedio(cantSalon, cali, x));
                Console.WriteLine("\tCalificacion maxima: " + mayor);
                Console.WriteLine("\tCalificacion minima: " + menor);

            }

           
        }

        public float calcularpromedio(int cantSalon, float [][]cali, int x)
        {
            acu = 0;
            int cant = cali[x].GetLength(0);
            for (int y = 0; y < cali[x].GetLength(0); y++)
                acu += cali[x][y];
            promedio = acu / cant;
            return promedio;
        }
    }
}
