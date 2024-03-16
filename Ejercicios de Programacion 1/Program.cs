// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Llamada
{
    public string NumeroOrigen { get; set; }
    public string NumeroDestino { get; set; }
    public int DuracionSegundos { get; set; }

    public virtual decimal CalcularCoste()
    {
        return 0; 
    }
}

class LlamadaLocal : Llamada
{
    public override decimal CalcularCoste()
    {
        return DuracionSegundos * 0.15m;
    }
}

class LlamadaProvincial : Llamada
{
    public int FranjaHoraria { get; set; }

    public override decimal CalcularCoste()
    {
        decimal costePorSegundo = 0;
        switch (FranjaHoraria)
        {
            case 1:
                costePorSegundo = 0.20m;
                break;
            case 2:
                costePorSegundo = 0.25m;
                break;
            case 3:
                costePorSegundo = 0.30m;
                break;
        }
        return DuracionSegundos * costePorSegundo;
    }
}

class Centralita
{
    private List<Llamada> llamadas = new List<Llamada>();

    public void RegistrarLlamada(Llamada llamada)
    {
        llamadas.Add(llamada);
        MostrarLlamada(llamada);
    }

    private void MostrarLlamada(Llamada llamada)
    {
        Console.WriteLine($"Llamada de {llamada.NumeroOrigen} a {llamada.NumeroDestino}, duración {llamada.DuracionSegundos} segundos, coste {llamada.CalcularCoste()} pesos");
    }

    public void MostrarInforme()
    {
        decimal facturacionTotal = 0;
        foreach (var llamada in llamadas)
        {
            facturacionTotal += llamada.CalcularCoste();
        }

        Console.WriteLine($"Número total de llamadas: {llamadas.Count}");
        Console.WriteLine($"Facturación total: {facturacionTotal} pesos");
    }
}

class Practica2
{
    static void Main()
    {
        Centralita centralita = new Centralita();
        centralita.RegistrarLlamada(new LlamadaLocal { NumeroOrigen = "111", NumeroDestino = "222", DuracionSegundos = 60 });
        centralita.RegistrarLlamada(new LlamadaProvincial { NumeroOrigen = "333", NumeroDestino = "444", DuracionSegundos = 120, FranjaHoraria = 2 });
        centralita.RegistrarLlamada(new LlamadaProvincial { NumeroOrigen = "555", NumeroDestino = "666", DuracionSegundos = 180, FranjaHoraria = 3 });

        centralita.MostrarInforme();
    }
}
