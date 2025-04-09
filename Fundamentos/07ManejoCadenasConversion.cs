using System;

namespace Conceptos
{
    class ManejoCadenasConversion
    {
        public static void Main(string[] args)
        {
            string cadena = "123"; //char cadena[] ("49", "50", "51")
            string hola = "hola"; //char cadena[] ("104", "111", "108", "97")
            string Hola = "Hola"; //char cadena[] ("72", "111", "108", "97")
            int numero;

            //Console.Write($"\n");
            Console.WriteLine($"");
            // Conversión de cadena a entero
            if (int.TryParse(cadena, out numero))
            {
                Console.WriteLine($"Conversión exitosa: {numero}");
            }
            else
            {
                Console.WriteLine("Conversión fallida.");
            }

            // Conversión de cadena a entero con try-catch
            string _cadena = "!$&/()!";
            try
            {
                numero = int.Parse(_cadena);
                Console.WriteLine($"2da Conversión exitosa: {numero}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Conversión fallida." + e.Message);
            }

            //Conversion de char a int32 ASCII
            char __cadena = 'a';
            try
            {
                numero = Convert.ToInt32(__cadena);
                Console.WriteLine($"3ra Conversión exitosa: {numero}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Conversión fallida." + e.Message);
            }

            // Concatenación de cadenas
            string saludo = "Hola";
            string nombre = "Mundo";
            string mensaje = saludo + ", " + nombre + "!";
            Console.WriteLine(mensaje);
        }
    }
}