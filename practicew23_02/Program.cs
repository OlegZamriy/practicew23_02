using System;

class MatrixOperations
{
    static void Main()
    {
        int[,] matrixA = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] matrixB = { { 7, 8, 9 }, { 10, 11, 12 } };

        Console.WriteLine("Матриця A:");
        PrintMatrix(matrixA);

        Console.WriteLine("\nМатриця B:");
        PrintMatrix(matrixB);

        int scalar = 2;

        Console.WriteLine($"\nМноження матриці A на число {scalar}:");
        int[,] resultScalar = MultiplyByScalar(matrixA, scalar);
        PrintMatrix(resultScalar);

        Console.WriteLine("\nДодавання матриць A і B:");
        int[,] resultAddition = AddMatrices(matrixA, matrixB);
        PrintMatrix(resultAddition);

        Console.WriteLine("\nДобуток матриць A і B:");
        int[,] resultProduct = MultiplyMatrices(matrixA, matrixB);
        PrintMatrix(resultProduct);
    }

    static int[,] MultiplyByScalar(int[,] matrix, int scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }

    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);
        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
