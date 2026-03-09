namespace ejercicio1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre:_ ");
            string nombre=Console.ReadLine();
            Saludar(nombre);

            static void Saludar(string nombre)
            {
                Console.WriteLine("Bienvenido " + nombre + " a mi primera funcion");
            }
        }
    }
}
