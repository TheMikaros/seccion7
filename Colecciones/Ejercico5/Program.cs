using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Usando Arrays, crea un programa que nos pida cuantos elementos tendrá el array,
            //dependiendo de ese numero de elementos, nos ira pidiendo valores, que introduciremos
            //en el array. una vez introducidos, nos pedirá un nuevo valor a insertar y la posición
            //donde queremos insertarla en el array.

            Console.WriteLine("Introduce la cantidad de elementos del array:");
            int cantidad = int.Parse(Console.ReadLine());

            int[] array = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Introduce el elemento " + (i + 1) + ":");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduce el valor a insertar:");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la posición donde quieres insertar el valor:");
            int posicion = int.Parse(Console.ReadLine());

            // Desplazamos los elementos del array hacia la derecha a partir de la posición donde queremos insertar el valor
            for (int i = array.Length - 1; i >= posicion; i--)
            {
                array[i + 1] = array[i];
            }

            // Insertamos el valor en la posición indicada
            array[posicion] = valor;

            // Mostramos el array resultante
            Console.WriteLine("Array resultante:");
            foreach (int elemento in array)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadLine();
        }
    }
}
