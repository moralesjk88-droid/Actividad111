// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número:_");
int n = int.Parse(Console.ReadLine());

bool primo =EsPrimo(n);

Console.WriteLine("¿Es primmo?: " + primo);

static bool EsPrimo(int n)
{
    if (n<=1)
    {
        return false;
    }
    for (int i = 2; i < n; i++)
    {
        if (n%i==0)
        {
            return false;
        }
    }
    return true;
}
