using System;

namespace ArrayAndMatrixDemo
{
    class ArrayOperations
    {
        // Bubble Sort implementation
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Print a 1-D array
        public void PrintArray(int[] arr)
        {
            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        // Flatten 2D array in row-major order
        public int[] RowMajor(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] result = new int[rows * cols];
            int k = 0;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[k++] = matrix[i, j];

            return result;
        }

        // Flatten 2D array in column-major order
        public int[] ColumnMajor(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] result = new int[rows * cols];
            int k = 0;

            for (int j = 0; j < cols; j++)
                for (int i = 0; i < rows; i++)
                    result[k++] = matrix[i, j];

            return result;
        }

        // Matrix multiplication
        public int[,] MultiplyMatrices(int[,] A, int[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int rowsB = B.GetLength(0);
            int colsB = B.GetLength(1);

            if (colsA != rowsB)
            {
                Console.WriteLine("Matrix multiplication not possible!");
                return new int[0, 0];
            }

            int[,] C = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return C;
        }

        // Print 2D matrix
        public void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            ArrayOperations obj = new ArrayOperations();

            // 1️⃣ Bubble Sort
            Console.WriteLine("=== Bubble Sort ===");
            int[] arr = { 5, 1, 4, 2, 8 };
            Console.WriteLine("Original array:");
            obj.PrintArray(arr);

            obj.BubbleSort(arr);
            Console.WriteLine("Sorted array:");
            obj.PrintArray(arr);

            // 2️⃣ Row and Column Major Order
            Console.WriteLine("\n=== Row and Column Major Order ===");
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            Console.WriteLine("Original 2D Array:");
            obj.PrintMatrix(matrix);

            int[] rowMajor = obj.RowMajor(matrix);
            int[] colMajor = obj.ColumnMajor(matrix);

            Console.WriteLine("Row Major Order (1D):");
            obj.PrintArray(rowMajor);

            Console.WriteLine("Column Major Order (1D):");
            obj.PrintArray(colMajor);

            // 3️⃣ Matrix Multiplication
            Console.WriteLine("\n=== Matrix Multiplication ===");
            int[,] A = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            int[,] B = {
                { 7, 8 },
                { 9, 10 },
                { 11, 12 }
            };

            Console.WriteLine("Matrix A:");
            obj.PrintMatrix(A);
            Console.WriteLine("Matrix B:");
            obj.PrintMatrix(B);

            int[,] C = obj.MultiplyMatrices(A, B);
            Console.WriteLine("Resultant Matrix C = A x B:");
            obj.PrintMatrix(C);
        }
    }
}
