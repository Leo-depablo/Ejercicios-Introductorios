// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
class Program
{
    //MENU
    static void Main()
    {
        
        Console.WriteLine("---- Menú ----");
        Console.WriteLine("1. Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.");
        Console.WriteLine("2. Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición de del arreglo está el mayor número par leído.");
        Console.WriteLine("3. Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.");
        Console.WriteLine("4. Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números negativos hay.");
        Console.WriteLine("5. Leer 10 números enteros, almacenarlos en un arreglo y calcular la factorial a cada uno de los números leídos almacenándolos en otro arreglo");

        //CAPTURANDO OPCIONES
        int i1 = 0;
        i1 = Convert.ToInt16(Console.ReadLine());

        //OPCIONES
        switch(i1)
        {
            case 1:
                Ejercicio1();
                break;
            case 2:
                Ejercicio2();
                break;
            case 3:
                Ejercicio3();
                break;
            case 4:
                Ejercicio4();
                break;
            case 5:
                Ejercicio5();
                break;
        }

        //EJERCICIO 1
        static void Ejercicio1()
        {
            int[] numeros = new int[10];

            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el entero número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int mayor = numeros[0];
            int posicion = 0;
            for (int i = 1; i < 10; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posicion = i;
                }
            }

            Console.WriteLine($"El mayor número ingresado es {mayor} y está en la posición {posicion} del arreglo.");
        }

        //EJERCICIO 2
        static void Ejercicio2()
        {
            int[] numerosPares = new int[10];
            int cantidadPares = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el entero número {i + 1}: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    numerosPares[cantidadPares] = numero;
                    cantidadPares++;
                }
            }
            if (cantidadPares > 0)
            {
                int mayorPar = numerosPares[0];
                for (int i = 1; i < cantidadPares; i++)
                {
                    if (numerosPares[i] > mayorPar)
                    {
                        mayorPar = numerosPares[i];
                    }
                }
                Console.WriteLine($"El mayor número par ingresado es {mayorPar}.");
            }
        }

        //EJERCICIO 3
        static void Ejercicio3()
        {
            bool esPrimo(int num)
            {
                if (num <= 1)
                    return false;
                if (num <= 3)
                    return true;
                if (num % 2 == 0 || num % 3 == 0)
                    return false;
                for (int i = 5; i * i <= num; i += 6)
                {
                    if (num % i == 0 || num % (i + 2) == 0)
                        return false;
                }
                return true;
            }
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el entero número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            int mayorPrimo = 0;
            int posicion = -1;
            for (int i = 0; i < 10; i++)
            {
                if (esPrimo(numeros[i]) && numeros[i] > mayorPrimo)
                {
                    mayorPrimo = numeros[i];
                    posicion = i;
                }
            }
            if (posicion != -1)
            {
                Console.WriteLine($"El mayor número primo ingresado es {mayorPrimo} y está en la posición {posicion} del arreglo.");
            }
        }
        //EJERCICIO 4
        static void Ejercicio4()
        {
            int[] numeros = new int[10];

            int contadorNegativos = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el número entero {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] < 0)
                {
                    contadorNegativos++;
                }
            }

            Console.WriteLine($"Hay {contadorNegativos} números negativos en el arreglo.");
        }
        //EJERCICIO 5
        static void Ejercicio5()
        {
            // Factorial
            int factorial(int n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * factorial(n - 1);
            }

            // Leyendo 10 numeros
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el número entero {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Almacenar en el arreglo
            int[] factoriales = new int[10];
            for (int i = 0; i < 10; i++)
            {
                factoriales[i] = factorial(numeros[i]);
            }

            // Resultados
            Console.WriteLine("Números ingresados:");
            foreach (var num in numeros)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nFactoriales calculados:");
            foreach (var fac in factoriales)
            {
                Console.Write(fac + " ");
            }


        }   
    }
}

    