using System;

namespace Conceptos
{
    class VariablesTiposDatos
    {
        public static void Main(string[] args)
        {
            int entero = 10;
            float flotante = 20.5f; // 1111 1111 1111 1111
            double doble = 20.5; // 1111 1111 1111 1111 1111 1111 1111 1111
            bool booleano = true; //1, 0
            string cadena = "Hola, C#";//'' != ""
            char caracter = 'A';

            Console.WriteLine($"\nEntero: {entero}");
            Console.WriteLine($"Flotante: {flotante}");
            Console.WriteLine($"Doble: {doble}");
            Console.WriteLine($"Booleano: {booleano}");
            Console.WriteLine($"Cadena: {cadena}");
            Console.WriteLine($"Caracter: {caracter}");
        }
    }
}