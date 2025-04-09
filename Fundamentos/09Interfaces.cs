using System;

public interface IVehiculo
{
    void Arrancar();
    void Detener();
    void Acelerar()
    {
        Console.WriteLine("Se acelera.");
    }
    void Frenar()
    {
        Console.WriteLine("Se frena.");
    }
}

public class Bicicleta : IVehiculo
{
    public void Arrancar()
    {
        Console.WriteLine("La bicicleta comienza a moverse.");
    }

    public void Detener()
    {
        Console.WriteLine("La bicicleta se detiene.");
    }

    public void Acelerar()
    {
        Console.WriteLine("La bicicleta acelera.");
    }
}

public class Coche : IVehiculo
{
    public void Arrancar()
    {
        Console.WriteLine("El coche arranca.");
    }

    public void Detener()
    {
        Console.WriteLine("El coche se detiene.");
    }
}

public class InterfacesEjemplo
{
    public static void Main()
    {
        IVehiculo bicicleta = new Bicicleta();
        IVehiculo coche = new Coche();

        bicicleta.Arrancar();
        bicicleta.Acelerar();
        bicicleta.Frenar();
        bicicleta.Detener();

        coche.Arrancar();
        coche.Acelerar();
        coche.Detener();
    }
}