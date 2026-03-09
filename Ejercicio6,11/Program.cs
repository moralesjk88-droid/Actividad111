// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escriba su nombre:_ ");
string nombre = Console.ReadLine().ToUpper ();
Saludar(nombre);

static void Saludar(string nombre)
{
    Console.WriteLine("Hola "+nombre);
}
