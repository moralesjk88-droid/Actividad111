// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero positivo:_");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un numero positivo:_");
int m = int.Parse(Console.ReadLine());

bool resultado = EsMultiplo(n,m);

Console.WriteLine("¿Es múltiplo?: " + resultado);
static bool EsMultiplo(int n, int m)
{
    return n%m == 0;
}