using System;

// Clase base Comida
public class Comida
{
    // Propiedades
    public string Nombre { get; set; }
    public string Origen { get; set; }

    // Constructor
    public Comida(string nombre, string origen)
    {
        Nombre = nombre;
        Origen = origen;
    }

    // Método virtual para describir la comida
    public virtual void Descripcion()
    {
        Console.WriteLine($"Comida: {Nombre}, Origen: {Origen}");
    }

    // Método virtual para comer la comida
    public virtual void Comer()
    {
        Console.WriteLine($"¡Disfrutando de la comida {Nombre}!");
    }
}

// Clase derivada Postre
public class Postre : Comida
{
    // Propiedad específica de postre
    public bool EsHelado { get; set; }

    // Constructor
    public Postre(string nombre, string origen, bool esHelado) : base(nombre, origen)
    {
        EsHelado = esHelado;
    }

    // Sobrescribe el método Descripcion para postre
    public override void Descripcion()
    {
        string tipoPostre = EsHelado ? "Helado" : "Postre";
        Console.WriteLine($"Tipo: {tipoPostre}, Nombre: {Nombre}, Origen: {Origen}");
    }

    // Sobrescribe el método Comer para postre
    public override void Comer()
    {
        string disfrutar = EsHelado ? "¡Mmm... qué delicioso helado de " : "¡Disfrutando de ";
        Console.WriteLine($"{disfrutar}{Nombre}!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creando instancias de las clases derivadas
        Comida comidaPrincipal = new Comida("Pizza", "Italia");
        Postre postre = new Postre("Pastel de Chocolate", "Francia", false);
        Postre helado = new Postre("Vainilla", "Estados Unidos", true);

        // Llamando a métodos de la clase base y clase derivada
        comidaPrincipal.Descripcion();
        comidaPrincipal.Comer();

        postre.Descripcion();
        postre.Comer();

        helado.Descripcion();
        helado.Comer();
    }
}
