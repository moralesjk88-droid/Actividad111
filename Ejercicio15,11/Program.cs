// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero positivo:_");
int nunero= int.Parse(Console.ReadLine());

bool resultado = EsPar(nunero);

Console.WriteLine("El resultado es:_ " + resultado);
static bool EsPar(int a)
{
    return a % 2 == 0;
}