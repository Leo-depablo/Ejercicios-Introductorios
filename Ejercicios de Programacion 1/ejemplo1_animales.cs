using System;

// Clase base
public class Animal
{
    // Propiedades
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor
    public Animal(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Método virtual para ser sobrescrito por las clases derivadas
    public virtual void HacerSonido()
    {
        Console.WriteLine("Haciendo algún sonido genérico...");
    }
}

// Clase derivada (hereda de Animal)
public class Perro : Animal
{
    // Propiedades adicionales
    public string Raza { get; set; }

    // Constructor
    public Perro(string nombre, int edad, string raza) : base(nombre, edad)
    {
        Raza = raza;
    }
}
    