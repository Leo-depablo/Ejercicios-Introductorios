using System;
using System.Collections.Generic;

public class Hamburguesa
{
    public string TipoDePan { get; }
    public string TipoDeCarne { get; }
    public double PrecioBase { get; }
    protected List<string> IngredientesAdicionales = new List<string>();

    public Hamburguesa(string tipoDePan, string tipoDeCarne, double precioBase)
    {
        TipoDePan = tipoDePan;
        TipoDeCarne = tipoDeCarne;
        PrecioBase = precioBase;
    }

    public virtual void AgregarIngrediente(string ingrediente)
    {
        if (IngredientesAdicionales.Count < 4)
        {
            IngredientesAdicionales.Add(ingrediente);
            Console.WriteLine("Ingrediente " + ingrediente + " agregado por $" + ObtenerPrecioAdicional(ingrediente));
        }
        else
        {
            Console.WriteLine("No se pueden agregar más de 4 ingredientes adicionales.");
        }
    }

    public virtual double ObtenerPrecio()
    {
        double precioTotal = PrecioBase;
        Console.WriteLine("Hamburguesa " + GetType().Name + " - Precio Base: $" + PrecioBase);
        foreach (var ingrediente in IngredientesAdicionales)
        {
            precioTotal += ObtenerPrecioAdicional(ingrediente);
            Console.WriteLine("Ingrediente " + ingrediente + " - Precio Adicional: $" + ObtenerPrecioAdicional(ingrediente));
        }
        Console.WriteLine("Precio Total: $" + precioTotal);
        return precioTotal;
    }

    protected virtual double ObtenerPrecioAdicional(string ingrediente)
    {
        // Precio adicional por ingrediente (ejemplo)
        switch (ingrediente)
        {
            case "lechuga":
            case "tomate":
                return 1.0;
            case "bacon":
                return 1.5;
            case "pepinillo":
                return 0.75;
            default:
                return 0.0; // Si el ingrediente no tiene precio adicional
        }
    }
}

public class HamburguesaSaludable : Hamburguesa
{
    public HamburguesaSaludable(string tipoDePan, string tipoDeCarne, double precioBase) : base(tipoDePan, tipoDeCarne, precioBase)
    {
    }

    public override void AgregarIngrediente(string ingrediente)
    {
        if (IngredientesAdicionales.Count < 6)
        {
            IngredientesAdicionales.Add(ingrediente);
            Console.WriteLine("Ingrediente " + ingrediente + " agregado por $" + ObtenerPrecioAdicional(ingrediente));
        }
        else
        {
            Console.WriteLine("No se pueden agregar más de 6 ingredientes adicionales a la hamburguesa saludable.");
        }
    }

    protected override double ObtenerPrecioAdicional(string ingrediente)
    {
        // Precio adicional por ingrediente (ejemplo)
        switch (ingrediente)
        {
            case "lechuga":
            case "tomate":
            case "pepino":
            case "cebolla":
                return 1.0;
            case "aguacate":
                return 2.0;
            default:
                return 0.0; // Si el ingrediente no tiene precio adicional
        }
    }
}

public class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium(string tipoDePan, string tipoDeCarne, double precioBase) : base(tipoDePan, tipoDeCarne, precioBase)
    {
        IngredientesAdicionales.Add("papas");
        IngredientesAdicionales.Add("bebida");
    }

    public override void AgregarIngrediente(string ingrediente)
    {
        Console.WriteLine("No se pueden agregar ingredientes adicionales a la hamburguesa premium.");
    }

    public override double ObtenerPrecio()
    {
        double precioTotal = PrecioBase;
        Console.WriteLine("Hamburguesa " + GetType().Name + " - Precio Base: $" + PrecioBase);
        foreach (var ingrediente in IngredientesAdicionales)
        {
            precioTotal += ObtenerPrecioAdicional(ingrediente);
            Console.WriteLine("Adicional: " + ingrediente + " - Precio Adicional: $" + ObtenerPrecioAdicional(ingrediente));
        }
        Console.WriteLine("Precio Total: $" + precioTotal);
        return precioTotal;
    }

    protected override double ObtenerPrecioAdicional(string ingrediente)
    {
        // Precio adicional por adicional (ejemplo)
        switch (ingrediente)
        {
            case "papas":
                return 2.0;
            case "bebida":
                return 1.5;
            default:
                return 0.0; // Si el ingrediente no tiene precio adicional
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hamburguesa hamburguesaClasica = new Hamburguesa("blanco", "res", 5.0);
        hamburguesaClasica.AgregarIngrediente("lechuga");
        hamburguesaClasica.AgregarIngrediente("tomate");
        hamburguesaClasica.AgregarIngrediente("bacon");
        hamburguesaClasica.AgregarIngrediente("pepinillo");
        hamburguesaClasica.ObtenerPrecio();

        HamburguesaSaludable hamburguesaSaludable = new HamburguesaSaludable("integral", "pavo", 6.0);
        hamburguesaSaludable.AgregarIngrediente("lechuga");
        hamburguesaSaludable.AgregarIngrediente("tomate");
        hamburguesaSaludable.AgregarIngrediente("pepino");
        hamburguesaSaludable.AgregarIngrediente("aguacate");
        hamburguesaSaludable.ObtenerPrecio();

        HamburguesaPremium hamburguesaPremium = new HamburguesaPremium("blanco", "res", 7.0);
        hamburguesaPremium.ObtenerPrecio();
    }
}
