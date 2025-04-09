using System;

public class EventoEjemplo
{
    // Definición de un evento usando EventHandler
    public event EventHandler? EventoDisparado;

    // Delegado personalizado
    public delegate void MiDelegado(string mensaje);
    public MiDelegado? DelegadoPersonalizado;

    // Uso de Action<>
    public Action<string>? Accion;

    // Uso de Func<>
    public Func<int, int, int>? Funcion;

    public void DispararEvento()
    {
        Console.WriteLine("Disparando evento...");
        EventoDisparado?.Invoke(this, EventArgs.Empty);
    }

    public void EjecutarDelegado(string mensaje)
    {
        DelegadoPersonalizado?.Invoke(mensaje);
    }

    public void EjecutarAccion(string mensaje)
    {
        Accion?.Invoke(mensaje);
    }

    public int EjecutarFuncion(int a, int b)
    {
        return Funcion != null ? Funcion(a, b) : 0;
    }
}

public class ManejoEventos
{
    public static void Main()
    {
        EventoEjemplo ejemplo = new EventoEjemplo();

        // Suscribirse al evento
        ejemplo.EventoDisparado += (sender, e) =>
        {
            Console.WriteLine("Evento recibido: ¡El evento fue disparado!");
        };

        // Asignar un delegado personalizado
        ejemplo.DelegadoPersonalizado = mensaje =>
        {
            Console.WriteLine($"Delegado personalizado ejecutado con mensaje: {mensaje}");
        };

        // Asignar una acción
        ejemplo.Accion = mensaje =>
        {
            Console.WriteLine($"Acción ejecutada con mensaje: {mensaje}");
        };

        // Asignar una función
        ejemplo.Funcion = (a, b) =>
        {
            Console.WriteLine($"Func ejecutada con valores: {a} + {b}");
            return a + b;
        };

        // Disparar el evento
        ejemplo.DispararEvento();

        // Ejecutar el delegado
        ejemplo.EjecutarDelegado("Hola desde el delegado");

        // Ejecutar la acción
        ejemplo.EjecutarAccion("Hola desde la acción");

        // Ejecutar la función
        int resultado = ejemplo.EjecutarFuncion(5, 10);
        Console.WriteLine($"Resultado de la función: {resultado}");
    }
}