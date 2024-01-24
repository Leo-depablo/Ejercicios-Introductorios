// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escribe un año a evaluar");
string i = Console.ReadLine();
int a = int.Parse(i.ToString());
if (a % 4 == 0 && ((a % 100 != 0) | (a % 400 == 0)))
{
    Console.WriteLine("Es bisiesto");
}
else{
    Console.WriteLine("no es bisiesto");
}
