// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese texto:_");
string texto = Console.ReadLine();
Console.WriteLine("Cuantas veces desea ver el texto:_ ");
int veces = int.Parse(Console.ReadLine());
string resultado=Repetido(texto, veces);
Console.WriteLine(resultado);
static string Repetido(string texto, int veces)
{
    string resultado = " ";
    for (int i = 0; i < veces; i++)
    {
        resultado += texto + "\n";
    }
    return resultado;
}
