using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(-100, 101); 
            }
        }

        Console.WriteLine("Двовимірний масив:");
        PrintArray(array);

        int min = array[0, 0];
        int max = array[0, 0];
        int minRow = 0, minCol = 0;
        int maxRow = 0, maxCol = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minRow = i;
                    minCol = j;
                }
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        Console.WriteLine($"Мінімальний елемент: {min} (рядок {minRow + 1}, стовпець {minCol + 1})");
        Console.WriteLine($"Максимальний елемент: {max} (рядок {maxRow + 1}, стовпець {maxCol + 1})");

        int sum = 0;
        int startRow = Math.Min(minRow, maxRow) + 1;
        int endRow = Math.Max(minRow, maxRow) - 1;
        int startCol = Math.Min(minCol, maxCol) + 1;
        int endCol = Math.Max(minCol, maxCol) - 1;
        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startCol; j <= endCol; j++)
            {
                sum += array[i, j];
            }
        }

        Console.WriteLine($"Сума елементів між мінімальним і максимальним елементами: {sum}");
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
