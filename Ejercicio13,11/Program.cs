// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el multiplicando:_");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese multiplicador:_ ");
int b = int.Parse(Console.ReadLine());

int resultado = Multiplicar(a, b);
Console.WriteLine("La producto de la multiplicacion es:_ " + resultado);
static int Multiplicar(int a, int b)
{
    return a * b;
}