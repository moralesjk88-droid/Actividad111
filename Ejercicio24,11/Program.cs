// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número");
int n=int.Parse(Console.ReadLine());

int resultado=Factorial(n);

Console.WriteLine("El factorial es:_" + resultado);

static int Factorial(int n)
{
    int factorial = 1;
    for(int i = 0; i < n; i++)
    { 
        factorial *= i; 
    }
    return factorial;
}