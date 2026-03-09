// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número:_ ");
int numero = int.Parse(Console.ReadLine());
MosstrarDoble(numero);
static void MosstrarDoble(int n)
{
    Console.WriteLine("El doble es:_ " + (n * 2));
}


