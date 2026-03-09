// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese texto:_");
string texto=Console.ReadLine();
Console.WriteLine("Cuantas veces desea ver el texto:_ ");
int veces=int.Parse(Console.ReadLine());
ImprimirREpetido(texto, veces);
static void ImprimirREpetido (string texto, int veces)
{
    for (int i = 0; i < veces; i++)
    {
        Console.WriteLine((i + 1) + ". " + texto);
    }
}

