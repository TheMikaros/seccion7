using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3- Pedir por pantalla 10 números, que iremos almacenando en un Listado
            //(o 2 como prefiramos). al terminar de introducir los números, tendremos
            //que recorrer el/los listados, diciéndonos cuanto suman los pares y cuando los impares.

            List<int> lista = new List<int>();
            int sumaPares = 0;
            int sumaImpares = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Introduce el número " + i + ":");
                int numero = int.Parse(Console.ReadLine());
                lista.Add(numero);
            }

            foreach (int numero in lista)
            {
                if (numero % 2 == 0)
                {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }
            }

            Console.WriteLine("La suma de los números pares es: " + sumaPares);
            Console.WriteLine("La suma de los números impares es: " + sumaImpares);
        }
    }
}
