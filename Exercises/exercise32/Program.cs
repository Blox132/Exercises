using System;

namespace exercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del rombo: ");

            string input = Console.ReadLine() ?? "";
            int size;

            if (int.TryParse(input, out size))
            {
                if (size > 0)
                {
                    Rhombus myRhombus = new Rhombus(size);
                    myRhombus.Print();
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número mayor a 0.");
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