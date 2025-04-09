using System;

namespace Conceptos
{
    class Operadores
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            // Operadores aritméticos
            Console.WriteLine($"\nSuma: {a + b}");
            Console.WriteLine($"Resta: {a - b}");
            Console.WriteLine($"Multiplicación: {a * b}");
            Console.WriteLine($"División: {a / b}");

            // Operadores lógicos
            // && (AND), || (OR), ! (NOT) 
            bool resultado1 = (a > b) /*1*/ && (a != 0)/*1*/; //1
            Console.WriteLine($"\nResultado lógico: {resultado1}");
            bool resultado2 = (a < b) /*0*/ || (a != 0)/*1*/; //1
            Console.WriteLine($"Resultado lógico: {resultado2}");
            bool resultado3 = (a < b) /*0*/ || !(a != 0)/*0*/; //0
            Console.WriteLine($"Resultado lógico: {resultado3}");
        }
    }
}