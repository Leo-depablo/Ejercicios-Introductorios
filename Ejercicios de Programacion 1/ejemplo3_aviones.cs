using System;

// Clase base Avion
public class Avion
{
    // Propiedades
    public string Modelo { get; set; }
    public int CapacidadPasajeros { get; set; }

    // Constructor
    public Avion(string modelo, int capacidadPasajeros)
    {
        Modelo = modelo;
        CapacidadPasajeros = capacidadPasajeros;
    }

    // Método virtual para despegar
    public virtual void Despegar()
    {
        Console.WriteLine($"El avión {Modelo} está despegando.");
    }

    // Método virtual para aterrizar
    public virtual void Aterrizar()
    {
        Console.WriteLine($"El avión {Modelo} está aterrizando.");
    }
}

// Clase derivada Helicoptero
public class Helicoptero : Avion
{
    // Propiedad específica de helicóptero
    public int NumeroHelices { get; set; }

    // Constructor
    public Helicoptero(string modelo, int capacidadPasajeros, int numeroHelices) : base(modelo, capacidadPasajeros)
    {
        NumeroHelices = numeroHelices;
    }

    // Sobrescribe el método Despegar para helicóptero
    public override void Despegar()
    {
        Console.WriteLine($"El helicóptero {Modelo} con {NumeroHelices} hélices está despegando.");
    }

    // Sobrescribe el método Aterrizar para helicóptero
    public override void Aterrizar()
    {
        Console.WriteLine($"El helicóptero {Modelo} con {NumeroHelices} hélices está aterrizando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creando instancias de las clases derivadas
        Avion avionComercial = new Avion("Boeing 737", 150);
        Helicoptero helicopteroRescate = new Helicoptero("Sikorsky UH-60 Black Hawk", 15, 4);

        // Llamando a métodos de la clase base y clase derivada
        avionComercial.Despegar();
        avionComercial.Aterrizar();

        helicopteroRescate.Despegar();
        helicopteroRescate.Aterrizar();
    }
}
