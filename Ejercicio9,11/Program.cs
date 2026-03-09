// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese primer numero:_");
int numero1=int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo numero:_ ");
int numero2=int.Parse(Console.ReadLine());

SumarMostrar(numero1, numero2);
static void SumarMostrar(int a, int b)
{
    Console.WriteLine("La suma de ambos es:_ "+(a+b));
}


