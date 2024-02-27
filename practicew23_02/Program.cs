using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int min = FindMinValue(array);
        int max = FindMaxValue(array);

        Console.WriteLine("Мінімальне значення: " + min);
        Console.WriteLine("Максимальне значення: " + max);
    }

    static int FindMinValue(int[,] array)
    {
        int min = array[0, 0];

        foreach (int num in array)
        {
            if (num < min)
                min = num;
        }

        return min;
    }

    static int FindMaxValue(int[,] array)
    {
        int max = array[0, 0];

        foreach (int num in array)
        {
            if (num > max)
                max = num;
        }

        return max;
    }
}
