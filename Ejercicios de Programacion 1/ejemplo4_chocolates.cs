using System;

// Clase base Chocolate
public class Chocolate
{
    // Propiedades
    public string Marca { get; set; }
    public double Precio { get; set; }

    // Constructor
    public Chocolate(string marca, double precio)
    {
        Marca = marca;
        Precio = precio;
    }

    // Método virtual para describir el chocolate
    public virtual void Descripcion()
    {
        Console.WriteLine($"Chocolate {Marca}, Precio: ${Precio}");
    }

    // Método virtual para comer el chocolate
    public virtual void Comer()
    {
        Console.WriteLine($"¡Disfrutando del chocolate {Marca}!");
    }
}

// Clase derivada ChocolateBlanco
public class ChocolateBlanco : Chocolate
{
    // Propiedad específica de chocolate blanco
    public string TipoLeche { get; set; }

    // Constructor
    public ChocolateBlanco(string marca, double precio, string tipoLeche) : base(marca, precio)
    {
        TipoLeche = tipoLeche;
    }

    // Sobrescribe el método Descripcion para chocolate blanco
    public override void Descripcion()
    {
        Console.WriteLine($"Chocolate blanco {Marca}, Tipo de leche: {TipoLeche}, Precio: ${Precio}");
    }

    // Sobrescribe el método Comer para chocolate blanco
    public override void Comer()
    {
        Console.WriteLine($"¡Mmmm... este chocolate blanco {Marca} es delicioso!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creando instancias de las clases derivadas
        Chocolate chocolateNegro = new Chocolate("Hershey's", 2.5);
        ChocolateBlanco chocolateBlanco = new ChocolateBlanco("Nestlé", 3.0, "Leche entera");

        // Llamando a métodos de la clase base y clase derivada
        chocolateNegro.Descripcion();
        chocolateNegro.Comer();

        chocolateBlanco.Descripcion();
        chocolateBlanco.Comer();
    }
}
