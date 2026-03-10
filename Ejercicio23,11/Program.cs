// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número:_ ");
int n=int.Parse(Console.ReadLine());

int suma=SumarDel1AlN(n);

Console.WriteLine("La suma es: " + suma);

static int SumarDel1AlN(int n)
{
    int suma = 0;

    for (int i = 0; i < n; i++)
    {
        suma += i;  
    }
    return suma;

}