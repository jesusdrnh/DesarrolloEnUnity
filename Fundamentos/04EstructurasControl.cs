using System;

namespace Conceptos
{
    class EstructurasControl
    {
        public static void Main(string[] args)
        {
            int numero = 10;

            // Estructura if-else
            if (numero > 0)
            {
                Console.WriteLine("\nEl número es positivo.");
            }
            else if (numero == 0)
            {
                Console.WriteLine("El número es cero.");
            }
            else
            {
                Console.WriteLine("El número es negativo.");
            }

            string texto = "hola"; // Cambiar el valor de texto para probar los casos

            // Estructura switch
            switch (texto)
            {
                case "1":
                    Console.WriteLine("\nEl número es uno.");
                    break;
                case "10":
                    Console.WriteLine("El número es diez.");
                    break;
                case "dato 1":
                    Console.WriteLine("El dato es 1");
                    break;
                case "hola":
                    Console.WriteLine("El texto es hola");
                    break;
                default:
                    Console.WriteLine("La opción no existe.");
                    break;
            }

            Console.WriteLine($"\n");
            // Bucles
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For loop: {i}");
            }

            Console.WriteLine($"\n");
            int j = 5;
            while (j < 5)
            {
                Console.WriteLine($"While loop: {j}");
                j++;
            }

            Console.WriteLine($"\n");
            int k = 5;
            do
            {
                Console.WriteLine($"Do While loop: {k}");
                k++;
            }
            while (k < 5);
        }
    }
}