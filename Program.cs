using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar y definir datos
            Console.Write("Ingrese el número 1: ");
            int numero_01 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número 2: ");
            int numero_02 = int.Parse(Console.ReadLine());

            int producto = 0;

            //Realizar multiplicación
            for (int i = 0; i < numero_01; i++) {
                producto = producto + numero_02;
            }
            //Mostrar resultados
            Console.WriteLine($"El producto es: {producto}");
            Console.ReadKey();
        }
    }
}
