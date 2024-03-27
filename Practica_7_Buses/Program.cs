using System;
using System.Collections.Generic;

class Ruta
{
    public string Nombre { get; set; }
    public Dictionary<string, double> PreciosPorKilometro { get; set; }
    public int AsientosDisponibles { get; set; }
    public int PasajerosVendidos { get; set; }

    public Ruta(string nombre, int asientosDisponibles)
    {
        Nombre = nombre;
        AsientosDisponibles = asientosDisponibles;
        PasajerosVendidos = 0;
        PreciosPorKilometro = new Dictionary<string, double>();
    }

    public double CalcularTarifa(double distancia)
    {
        double tarifaTotal = 0;
        foreach (var precio in PreciosPorKilometro)
        {
            tarifaTotal += precio.Value * distancia;
        }
        return tarifaTotal;
    }

    public void VenderPasajes(int cantidadPasajes)
    {
        PasajerosVendidos += cantidadPasajes;
        AsientosDisponibles -= cantidadPasajes;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Auto Bus {Nombre} {PasajerosVendidos} Pasajeros Ventas {CalcularTarifa(1)} quedan {AsientosDisponibles} asientos disponibles");
    }
}

class Program
{
    static void Main()
    {
        Ruta rutaPlatinum = new Ruta("Plantinum", 22);
        rutaPlatinum.PreciosPorKilometro.Add("Tramo 1", 0.5);
        rutaPlatinum.PreciosPorKilometro.Add("Tramo 2", 0.6);

        Ruta rutaGold = new Ruta("Gold", 15);
        rutaGold.PreciosPorKilometro.Add("Tramo 1", 0.7);
        rutaGold.PreciosPorKilometro.Add("Tramo 2", 0.8);

        Console.WriteLine($"Bienvenido a la Ruta {rutaPlatinum.Nombre}");
        Console.Write("Ingrese la distancia recorrida en kilómetros: ");
        double distanciaPlatinum = double.Parse(Console.ReadLine());
        rutaPlatinum.VenderPasajes(5);
        rutaPlatinum.MostrarInformacion();

        Console.WriteLine($"Bienvenido a la Ruta {rutaGold.Nombre}");
        Console.Write("Ingrese la distancia recorrida en kilómetros: ");
        double distanciaGold = double.Parse(Console.ReadLine());
        rutaGold.VenderPasajes(3);
        rutaGold.MostrarInformacion();
    }
}
