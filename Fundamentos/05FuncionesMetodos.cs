using System;

namespace Conceptos
{
    class FuncionesMétodos
    {
        public static void Main(string[] args)
        {
            int resultado = Sumar(5, 3);
            Console.WriteLine($"\nResultado de la suma: {resultado}");
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static float restar(int a, int b)
        {
            return a - b;
        }
    }
}