using System;

namespace exercise33
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el valor de m: ");
                string inputM = Console.ReadLine() ?? "";
                int m = int.Parse(inputM);

                Console.Write("Ingrese el valor de n: ");
                string inputN = Console.ReadLine() ?? "";
                int n = int.Parse(inputN);

                Console.Write("Ingrese el valor de p: ");
                string inputP = Console.ReadLine() ?? "";
                int p = int.Parse(inputP);

                if (m <= 0 || n <= 0 || p <= 0)
                {
                    Console.WriteLine("Los valores deben ser mayores a cero.");
                    return;
                }

                MatrixLogic logic = new MatrixLogic(m, n, p);

                int[,] matrixA = logic.CreateMatrixA();
                int[,] matrixB = logic.CreateMatrixB();
                int[,] matrixC = logic.MultiplyMatrices(matrixA, matrixB);

                logic.PrintMatrix(matrixA, "A");
                logic.PrintMatrix(matrixB, "B");
                logic.PrintMatrix(matrixC, "C");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor ingrese solo números enteros.");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}