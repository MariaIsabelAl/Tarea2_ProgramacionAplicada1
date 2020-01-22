using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea2_ProgramacionAplicada1
{
    class Agenda
    {
        int cant;
        class Persona
        {
            public string nombre, numero;

        }

        public void guardar()
        {
            Persona p = new Persona();
            ArrayList lista = new ArrayList();

            Console.WriteLine("Digite la cantidad de numeros que desea almacenar en la agenda:");
            cant = Convert.ToInt32(Console.ReadLine());

            for(int x = 0; x < cant; x++)
            {
                Console.WriteLine("\nEscriba el nombre de la persona [" + (x + 1) + "]: ");
                p.nombre = Console.ReadLine();

                Console.WriteLine("\nEscriba el numero de la persona [" + (x + 1) + "]: ");
                p.numero = Console.ReadLine();

                lista.Add(p);
            }
        }
    }
}
