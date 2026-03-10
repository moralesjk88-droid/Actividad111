// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el primer numero:_");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
int b = int.Parse(Console.ReadLine());

double resultado = Mayor(a, b);
Console.WriteLine("El resultado es:_ " + resultado);
static int Mayor(int a, int b)
{
    if (a>b)
    {
        return a; 
    }
    else 
    {
        return b;
    }
   
}