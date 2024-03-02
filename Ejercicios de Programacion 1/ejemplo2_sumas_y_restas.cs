using System;

// Clase base
public class OperacionMatematica
{
    // Método para sumar dos números
    public int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    // Método para restar dos números
    public int Restar(int num1, int num2)
    {
        return num1 - num2;
    }
}

// Clase derivada que hereda de OperacionMatematica
public class Multiplicacion : OperacionMatematica
{
    // Método para multiplicar dos números
    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
}

// Clase derivada que hereda de OperacionMatematica
public class Division : OperacionMatematica
{
    // Método para dividir dos números
    public double Dividir(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("No se puede dividir por cero.");
            return 0;
        }
        else
        {
            return (double)num1 / num2;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creando instancias de las clases derivadas
        Multiplicacion multiplicacion = new Multiplicacion();
        Division division = new Division();

        // Realizando operaciones matemáticas
        int resultadoSuma = multiplicacion.Sumar(5, 3);
        Console.WriteLine("Resultado de la suma: " + resultadoSuma);

        int resultadoResta = multiplicacion.Restar(10, 4);
        Console.WriteLine("Resultado de la resta: " + resultadoResta);

        int resultadoMultiplicacion = multiplicacion.Multiplicar(5, 4);
        Console.WriteLine("Resultado de la multiplicación: " + resultadoMultiplicacion);

        double resultadoDivision = division.Dividir(10, 2);
        Console.WriteLine("Resultado de la división: " + resultadoDivision);
    }
}
