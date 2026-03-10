// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un texto:_");
string texto = Console.ReadLine();

int vocales = ContarVocales(texto);

Console.WriteLine("Cantidad de caracteres:_ " + vocales);

static int ContarVocales(string texto)
{
    int contador = 0;
    foreach (char letra in texto.ToLower())
    {
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        {
            contador++;
        }
    }
    return contador;
}