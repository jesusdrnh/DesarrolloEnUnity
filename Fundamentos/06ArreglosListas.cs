namespace Conceptos
{
    class ArreglosListas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"\n");
            // Arreglo
            int[] arreglo = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Arreglo:");
            foreach (int num in arreglo)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine($"\n");

            // Lista
            List<int> lista = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Lista:");
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }

            //Arreglo en lista:
            Console.WriteLine($"\n");
            string[] Mexico = { "CDMX", "Jalisco", "Nuevo Leon" };
            string[] USA = { "California", "Texas", "Florida" };
            string[] Canada = { "Ontario", "Quebec", "British Columbia" };

            List<string[]> NorteAmerica = new List<string[]> { Mexico, USA, Canada };
            Console.WriteLine(NorteAmerica[0][2]);

            //Lista en arreglo:
            Console.WriteLine($"\n");
            List<string> _Mexico = new List<string> { "CDMX", "Jalisco", "Nuevo Leon" };
            List<string> _USA = new List<string> { "California", "Texas", "Florida" };
            List<string> _Canada = new List<string> { "Ontario", "Quebec", "British Columbia" };

            string[] _NorteAmerica = { _Mexico[0], _Mexico[1], _Mexico[2], _USA[0], _USA[1], _USA[2], _Canada[0], _Canada[1], _Canada[2] };
            Console.WriteLine(_NorteAmerica[2]);

            //Arreglo anidado:
            Console.WriteLine($"\n");
            string[] __Mexico = { "CDMX", "Jalisco", "Nuevo Leon" };
            string[] __USA = { "California", "Texas", "Florida" };
            string[] __Canada = { "Ontario", "Quebec", "British Columbia" };

            string[][] __NorteAmerica = { __Mexico, __USA, __Canada };
            Console.WriteLine(__NorteAmerica[0][2]);

            //Lista anidada:
            Console.WriteLine($"\n");
            List<string> ___Mexico = new List<string> { "CDMX", "Jalisco", "Nuevo Leon" };
            List<string> ___USA = new List<string> { "California", "Texas", "Florida" };
            List<string> ___Canada = new List<string> { "Ontario", "Quebec", "British Columbia" };

            List<List<string>> ___NorteAmerica = new List<List<string>> { ___Mexico, ___USA, ___Canada };
            Console.WriteLine(___NorteAmerica[0][2]);
        }
    }
}