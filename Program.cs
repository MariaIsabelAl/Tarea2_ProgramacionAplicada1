using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2_ProgramacionAplicada1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string respuesta = " ";

            Factorial f = new Factorial();
            Cadena c = new Cadena();
            Salon a = new Salon();
            Dicionario d = new Dicionario();
            Clases cla = new Clases();
            Agenda p = new Agenda();
            Fecha fe = new Fecha();
            Ordenar o = new Ordenar();

            Console.WriteLine("                                        MENU TAREA 2");
            Console.WriteLine("Capitulo 5");
            Console.WriteLine("1. Hacer una función que calcule la factorial de un número.");
            Console.WriteLine("2. Hacer una función que dado un número nos regrese una cadena donde se encuentre escrito en palabras.");

            Console.WriteLine("Capitulo 6");
            Console.WriteLine("3. Todos juntos.");

            Console.WriteLine("Capitulo 7");
            Console.WriteLine("4. Hacer el programa que calcula el promedio, calificación máxima y mínima de un salón de clases usando el ArrayList.");
            Console.WriteLine("5. Hacer un programa que funcione como un diccionario, con palabra y definición, usando el Hashtable");
            Console.WriteLine("6. Hacer un programa que funcione como una agenda telefónica y que guarde el nombre de la persona y su número telefónico.");

            Console.WriteLine("Capitulo 8");
            Console.WriteLine("7. Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.");
            Console.WriteLine("8. Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.");
            
            do
            {
                Console.WriteLine("Elija la opcion del Menu Principal");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Capitulo 5, ejercicio 1");
                        f.calcularfactorial();
                        break;
                    case 2:
                        Console.WriteLine("Capitulo 5, ejercicio 2");
                        c.cadena();
                        break;
                    case 3:
                        Console.WriteLine("Capitulo 6, Todos");
                        cla.colegio();
                        break;
                    case 4:
                        Console.WriteLine("Capitulo 7, ejercicio 1");
                        a.lista();
                        break;
                    case 5:
                        Console.WriteLine("Capitulo 7, ejercicio 2");
                        d.correr();
                        break;
                    case 6:
                         Console.WriteLine("Capitulo 7, ejercicio 5");
                        p.guardar();
                        break;
                    case 7:
                        Console.WriteLine("Capitulo 8, ejercicio 3");
                        fe.formato();
                        break;
                    case 8:
                        Console.WriteLine("Capitulo 8, ejercicio 5");
                        o.orden();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
                Console.WriteLine(" ");
                Console.WriteLine("Deseas volver al Menu Principal (si / no) ?");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");

        }
    }
}
