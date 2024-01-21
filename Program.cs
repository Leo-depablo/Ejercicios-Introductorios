// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
class Program
{
    //MENU
    static void Main()
    {
        Console.WriteLine("---- Menú ----");
        Console.WriteLine("1. Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.");
        Console.WriteLine("2. Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.");
        Console.WriteLine("3. Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.");
        Console.WriteLine("4. Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.");
        Console.WriteLine("5. Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.");
        Console.WriteLine("6. Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.");
        Console.WriteLine("7. Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.");
        Console.WriteLine("8. Leer un número entero de cinco dígitos y determinar si es un número Capicúa.");
        Console.WriteLine("9. Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.");
        Console.WriteLine("10. Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.");
        Console.WriteLine("0. Salir");


        //CAPTURANDO OPCIONES
        int i1 = 0;
        i1 = Convert.ToInt16(Console.ReadLine());

        switch(i1)
        {
            case 1:
                Ejercicio1();
                break;
            case 3:
                DeterminarDigitosPrimos();
                break;
            case 4:
                Ejercicio4();
                break;
            case 5:
                Ejercicio5();
                break;
            case 6:
                Ejercicio6();
                break;
            case 7:
                Ejercicio7();
                break;
            case 8:
                Ejercicio8();
                break;
            case 9:
                Ejercicio9();
                break;
            case 10:
                Ejercicio10();
                break;
        }

        //OPCIONES

        //EJERCICIO 1
        static void Ejercicio1()
        {
            Console.WriteLine("Ingrese un numero entero de dos cifras: ");
                string leer = Console.ReadLine();
                if (leer.Length == 2)
                {
                    int a = int.Parse(leer[0].ToString());
                    int b = int.Parse(leer[1].ToString());
                    int sumar = a + b;
                    Console.WriteLine($"la suma de los digitos es: {sumar}");
                }
        }

        //EJERCICIO 3
        static void DeterminarDigitosPrimos()
        {
            Console.Write("Ingrese un número entero de dos dígitos: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 10 && numero <= 99)
            {
                int digito1 = numero / 10; // Obtener el primer dígito
                int digito2 = numero % 10; // Obtener el segundo dígito

                if (EsPrimo(digito1) && EsPrimo(digito2))
                {
                    Console.WriteLine($"Ambos dígitos ({digito1} y {digito2}) son primos.");
                }
                else
                {
                    Console.WriteLine($"Al menos uno de los dígitos ({digito1} o {digito2}) no es primo.");
                }
            }
            else
            {
                Console.WriteLine("Número no válido. Asegúrate de ingresar un número de dos dígitos.");
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        //EJERCICIO 4
        static void Ejercicio4()
        {
        Console.Write("Ingrese el primer número entero de dos dígitos: ");
        if (int.TryParse(Console.ReadLine(), out int numero1) && EsNumeroDeDosDigitos(numero1))
        {
            Console.Write("Ingrese el segundo número entero de dos dígitos: ");
            if (int.TryParse(Console.ReadLine(), out int numero2) && EsNumeroDeDosDigitos(numero2))
            {
                int suma = numero1 + numero2;

                if (EsPar(suma))
                {
                    Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}, y es un número par.");
                }
                else
                {
                    Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}, y no es un número par.");
                }
            }
            else
            {
                Console.WriteLine("El segundo número no es válido. Asegúrate de ingresar un número de dos dígitos.");
            }
        }
        else
        {
            Console.WriteLine("El primer número no es válido. Asegúrate de ingresar un número de dos dígitos.");
        }
        }

        static bool EsNumeroDeDosDigitos(int numero)
        {
            return numero >= 10 && numero <= 99;
        }

        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }

        //EJERCICIO 5
        static void Ejercicio5()
        {
        Console.Write("Ingrese un número entero de tres dígitos: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && EsNumeroDeTresDigitos(numero))
        {
            int digito1 = numero / 100;        // Obtener el primer dígito
            int digito2 = (numero / 10) % 10;  // Obtener el segundo dígito
            int digito3 = numero % 10;         // Obtener el tercer dígito

            if (digito1 >= digito2 && digito1 >= digito3)
            {
                Console.WriteLine($"El mayor dígito es {digito1} y se encuentra en la posición de las centenas.");
            }
            else if (digito2 >= digito1 && digito2 >= digito3)
            {
                Console.WriteLine($"El mayor dígito es {digito2} y se encuentra en la posición de las decenas.");
            }
            else
            {
                Console.WriteLine($"El mayor dígito es {digito3} y se encuentra en la posición de las unidades.");
            }
        }
        else
        {
            Console.WriteLine("Número no válido. Asegúrate de ingresar un número de tres dígitos.");
        }
        }

        static bool EsNumeroDeTresDigitos(int numero)
        {
            return numero >= 100 && numero <= 999;
        }

        //EJERCICIO 6
        static void Ejercicio6()
        {
        Console.Write("Ingrese un número entero de tres dígitos: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && NumeroDeTresDigitos(numero))
        {
            int digito1 = numero / 100;        // Obtener el primer dígito
            int digito2 = (numero / 10) % 10;  // Obtener el segundo dígito
            int digito3 = numero % 10;         // Obtener el tercer dígito

            if (EsMultiploDeOtros(digito1, digito2, digito3) ||
                EsMultiploDeOtros(digito2, digito1, digito3) ||
                EsMultiploDeOtros(digito3, digito1, digito2))
            {
                Console.WriteLine("Al menos un dígito es múltiplo de los otros.");
            }
            else
            {
                Console.WriteLine("Ningún dígito es múltiplo de los otros.");
            }
        }
        else
        {
            Console.WriteLine("Número no válido. Asegúrate de ingresar un número de tres dígitos.");
        }
        }

        static bool NumeroDeTresDigitos(int numero)
        {
            return numero >= 100 && numero <= 999;
        }

        static bool EsMultiploDeOtros(int digito, int otroDigito1, int otroDigito2)
        {
            return digito % otroDigito1 == 0 && digito % otroDigito2 == 0;
        }
        
        //EJERCICIO 7
        static void Ejercicio7()
        {
        Console.Write("Ingrese el primer número entero: ");
        if (int.TryParse(Console.ReadLine(), out int numero1))
        {
            Console.Write("Ingrese el segundo número entero: ");
            if (int.TryParse(Console.ReadLine(), out int numero2))
            {
                Console.Write("Ingrese el tercer número entero: ");
                if (int.TryParse(Console.ReadLine(), out int numero3))
                {
                    int mayor = numero1;

                    if (numero2 > mayor)
                    {
                        mayor = numero2;
                    }

                    if (numero3 > mayor)
                    {
                        mayor = numero3;
                    }

                    Console.WriteLine($"El mayor de los tres números es: {mayor}");
                }
                else
                {
                    Console.WriteLine("Número no válido. Asegúrate de ingresar un número entero.");
                }
            }
            else
            {
                Console.WriteLine("Número no válido. Asegúrate de ingresar un número entero.");
            }
            }
            else
            {
                Console.WriteLine("Número no válido. Asegúrate de ingresar un número entero.");
            }
        }
        
        //EJERCICIO 8
        static void Ejercicio8()
        {
        Console.Write("Ingrese un número entero de cinco dígitos: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && EsNumeroDeCincoDigitos(numero))
        {
            if (EsCapicua(numero))
            {
                Console.WriteLine($"{numero} es un número capicúa.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número capicúa.");
            }
        }
        else
        {
            Console.WriteLine("Número no válido. Asegúrate de ingresar un número de cinco dígitos.");
        }
        }

        static bool EsNumeroDeCincoDigitos(int numero)
        {
            return numero >= 10000 && numero <= 99999;
        }

        static bool EsCapicua(int numero)
        {
            int digito1 = numero / 10000;           // Obtener el primer dígito
            int digito2 = (numero / 1000) % 10;     // Obtener el segundo dígito
            int digito4 = (numero / 10) % 10;        // Obtener el cuarto dígito
            int digito5 = numero % 10;               // Obtener el quinto dígito

            return (digito1 == digito5) && (digito2 == digito4);
        }

        //EJERCICIO 9

        static void Ejercicio9()
        {
        Console.Write("Ingrese un número entero de cuatro dígitos: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && EsNumeroDeCuatroDigitos(numero))
        {
            if (SegundoIgualAlPenultimo(numero))
            {
                Console.WriteLine("El segundo dígito es igual al penúltimo.");
            }
            else
            {
                Console.WriteLine("El segundo dígito no es igual al penúltimo.");
            }
        }
        else
        {
            Console.WriteLine("Número no válido. Asegúrate de ingresar un número de cuatro dígitos.");
        }
        }

        static bool EsNumeroDeCuatroDigitos(int numero)
        {
            return numero >= 1000 && numero <= 9999;
        }

        static bool SegundoIgualAlPenultimo(int numero)
        {
            int segundoDigito = (numero / 100) % 10;   // Obtener el segundo dígito
            int penultimoDigito = (numero / 10) % 10;  // Obtener el penúltimo dígito

            return segundoDigito == penultimoDigito;
        }

        //EJERCICIO 10
        static void Ejercicio10()
        {
        Console.Write("Ingrese el primer número entero: ");
        if (int.TryParse(Console.ReadLine(), out int numero1))
        {
            Console.Write("Ingrese el segundo número entero: ");
            if (int.TryParse(Console.ReadLine(), out int numero2))
            {
                if (Math.Abs(numero1 - numero2) <= 10)
                {
                    Console.WriteLine($"Los números están dentro de un rango de 10. Mostrando enteros comprendidos:");

                    int menor = Math.Min(numero1, numero2);
                    int mayor = Math.Max(numero1, numero2);

                    for (int i = menor; i <= mayor; i++)
                    {
                        Console.Write($"{i} ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("La diferencia entre los dos números es mayor a 10. No se muestran enteros comprendidos.");
                }
            }
            else
            {
                Console.WriteLine("Número no válido. Asegúrate de ingresar un número entero.");
            }
            }
            else
            {
                Console.WriteLine("Número no válido. Asegúrate de ingresar un número entero.");
            }
        }
    }

}