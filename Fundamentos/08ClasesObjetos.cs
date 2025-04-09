public class Motocicleta(string marca, string? modelo, int año, string? color = null)
{
    private void MostrarInformación()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Año: {año}, Color: {color}");
    }

    public void mostrar()
    {
        MostrarInformación();
    }
}
public class Auto
{
    public string Marca { get; set; }
    static string? Modelo { get; set; }
    private int Año { get; set; }

    public Auto(string marca, string? modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public void MostrarInformación()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
    }
}

public class Autobus : Auto
{
    public int CapacidadPasajeros { get; set; }

    public Autobus(string marca, string? modelo, int año, int capacidadPasajeros) : base(marca, modelo, año)
    {
        CapacidadPasajeros = capacidadPasajeros;
    }

    public void MostrarInformación()
    {
        base.MostrarInformación();
        Console.WriteLine($"Capacidad de Pasajeros: {CapacidadPasajeros}");
    }
}

public class ClasesObjetos
{
    public static void Main()
    {
        Console.WriteLine($"");
        Auto auto1 = new Auto("Toyota", "Corolla", 2020);
        Auto auto2 = new Auto("Ford", "Mustang", 2021);
        Auto auto3 = new Auto("Chevrolet", "Camaro", 2022);

        auto1.MostrarInformación();
        auto2.MostrarInformación();
        auto3.MostrarInformación();

        auto1.Marca = "Honda";
        auto1.MostrarInformación();

        Console.Write($"\n");
        Motocicleta moto1 = new Motocicleta("Yamaha", "R1", 2020);
        Motocicleta moto2 = new Motocicleta("Honda", "CBR", 2021);
        Motocicleta moto3 = new Motocicleta("Suzuki", null, 2022, "Rojo");

        moto1.mostrar();
        moto2.mostrar();
        moto3.mostrar();

        Console.Write($"\n");
        Autobus autobus1 = new Autobus("Mercedes-Benz", "Sprinter", 2019, 20);
        autobus1.MostrarInformación();
    }
}