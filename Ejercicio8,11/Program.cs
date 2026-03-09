// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero:_ ");
int numero=int.Parse(Console.ReadLine());
MostrarCuadrado(numero);
static void MostrarCuadrado(int n)
{
    Console.WriteLine("El cuadrado del numero es :_ " + (n * n));
}
