using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Introduce el nombre " + i + ":");
                string nombre = Console.ReadLine();
                lista.Add(nombre);
            }

            Console.WriteLine("Introduce el nombre a buscar:");
            string nombreABuscar = Console.ReadLine();

            if (lista.Contains(nombreABuscar))
            {
                Console.WriteLine("El nombre está contenido en la lista");
            }
            else
            {
                Console.WriteLine("El nombre no está contenido en la lista");
            }
        }
    }
}
