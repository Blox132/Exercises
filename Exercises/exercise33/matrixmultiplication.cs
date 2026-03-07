using System;

namespace exercise33
{
    public class MatrixLogic
    {
        public int M { get; set; }
        public int N { get; set; }
        public int P { get; set; }

        public MatrixLogic(int m, int n, int p)
        {
            M = m;
            N = n;
            P = p;
        }

        public int[,] CreateMatrixA()
        {
            int[,] matrixA = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrixA[i, j] = (i + 1) * j;
                }
            }
            return matrixA;
        }

        public int[,] CreateMatrixB()
        {
            int[,] matrixB = new int[N, P];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    matrixB[i, j] = (j + 1) * i;
                }
            }
            return matrixB;
        }

        public int[,] MultiplyMatrices(int[,] A, int[,] B)
        {
            int[,] C = new int[M, P];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < N; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return C;
        }
        public void PrintMatrix(int[,] matrix, string name)
        {
            Console.WriteLine($"*** {name} ***");
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}