// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el primer numero:_");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer numero");
int c = int.Parse(Console.ReadLine());

double resultado = MenorDeTres(a, b, c);
Console.WriteLine("El resultado es:_ " + resultado);
static int MenorDeTres(int a, int b, int c)
{ 
  int menor = a;

if (b < menor)
    menor = b;

if (c < menor)
    menor = c;

return menor;
}