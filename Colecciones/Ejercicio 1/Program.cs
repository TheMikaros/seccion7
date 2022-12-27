using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            int suma = 0;

            for (int i = 1; i <= 1000; i++)
            {
                lista.Add(i);
                suma += i;
            }

            foreach (int numero in lista)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
            Console.WriteLine("La suma de los números es: " + suma);
        }
    }
}
