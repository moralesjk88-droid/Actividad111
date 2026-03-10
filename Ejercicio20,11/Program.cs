// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un texto:_");
string texto = Console.ReadLine();

int cantidad=ContarLetras(texto);

Console.WriteLine("Cantidad de caracteres:_ " + cantidad);

static int ContarLetras(string texto)
{
    return texto.Length;
}