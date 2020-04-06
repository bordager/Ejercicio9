using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es su nombre?");
            string nombre;
            nombre = Console.ReadLine();

            if (nombre != "")
            {
                Console.WriteLine("Hola " + nombre);
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
        }
    }
}
