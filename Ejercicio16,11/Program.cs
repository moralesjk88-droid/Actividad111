// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero:_");
int nunero = int.Parse(Console.ReadLine());

bool resultado = EsPositivo(nunero);

Console.WriteLine("¿El númro es positivo?:_ " + resultado);
static bool EsPositivo (int a)
{

        return a > 0;
    
    
}