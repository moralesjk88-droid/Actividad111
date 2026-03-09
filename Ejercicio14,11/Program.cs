// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el dividendo:_");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el divisor:_ ");
int b = int.Parse(Console.ReadLine());

int resultado = Divicion(a, b);
Console.WriteLine("El resultado es:_ " + resultado);
static int Divicion(int a, int b)
{
    return a / b;
}
