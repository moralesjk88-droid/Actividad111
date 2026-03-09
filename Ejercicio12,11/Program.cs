// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese primer numero:_");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo numero:_ ");
int b = int.Parse(Console.ReadLine());

int resultado = restar(a, b);
Console.WriteLine("La resultado es:_ " + resultado);
static int restar(int a, int b)
{
    return a - b;
}