namespace ejercicio2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre:_ "); 
            string nombre=Console.ReadLine().ToLower();
            Nombre(nombre);
         
        }
        static void Nombre(string nombre)
            {
                Console.WriteLine("Esta seguro que es su nombre? "+ nombre);
                
            }
        
    }
}
