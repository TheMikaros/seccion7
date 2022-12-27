using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4 - crea un programa nos pida introducir 10 números enteros. esos valores los
            //introduciremos en un Listado y  mostraremos el numero mayor y menor, consultando los valores en el Listado

            List<int> lista = new List<int>();
            int numeroMayor = int.MinValue;
            int numeroMenor = int.MaxValue;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Introduce el número " + i + ":");
                int numero = int.Parse(Console.ReadLine());
                lista.Add(numero);

                if (numero > numeroMayor)
                {
                    numeroMayor = numero;
                }
                if (numero < numeroMenor)
                {
                    numeroMenor = numero;
                }
            }

            Console.WriteLine("El número mayor es: " + numeroMayor);
            Console.WriteLine("El número menor es: " + numeroMenor);

        }
    }
}
