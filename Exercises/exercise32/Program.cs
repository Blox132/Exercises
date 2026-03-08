namespace exercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del rombo: ");

            string input = Console.ReadLine()!;
            int size;

            if (int.TryParse(input, out size))
            {
                if (size > 0 && size % 2 != 0)
                {
                    Rhombus myRhombus = new Rhombus(size);
                    myRhombus.Print();
                }
                else if (size % 2 == 0)
                {
                    Console.WriteLine("Error: El tamaño del rombo tiene que ser un número impar");
                }
                else
                {
                    Console.WriteLine("Error: Por favor, ingrese un número mayor a 0.");
                }
            }
            else
            {
                Console.WriteLine("Error: El dato ingresado no es un número válido.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}