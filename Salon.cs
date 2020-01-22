using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_ProgramacionAplicada1
{
    class Salon
    {
        public float cali;
        public void lista()
        {
            int cantidad;
            float mayor = 0, menor = 9999, acu = 0, promedio = 0;

            ArrayList l = new ArrayList();

            Console.WriteLine("Digite la cantidad de calificaciones");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Insertar Calificacion [" + (i + 1) + "]: ");
                cali = Convert.ToSingle(Console.ReadLine());
                l.Add(cali);
            }

            foreach(float cali in l)
            {
                if (cali > mayor)
                    mayor = cali;
                if (cali < menor)
                    menor = cali;

                acu += cali;
            }

            int cant = l.Count;
            promedio = acu / cant;

            Console.WriteLine("Promedio: " + promedio + "\nMayor: " + mayor + "\nMenor: " + menor);
        }
    }
}
