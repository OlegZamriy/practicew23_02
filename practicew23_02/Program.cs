using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 5, 6, 7 };

        HashSet<int> uniqueElements = new HashSet<int>();

        foreach (int num in array1)
        {
            uniqueElements.Add(num);
        }

        foreach (int num in array2)
        {
            if (!uniqueElements.Contains(num))
            {
                uniqueElements.Add(num);
            }
        }

        int[] combinedArray = new int[uniqueElements.Count];
        uniqueElements.CopyTo(combinedArray);

        Console.WriteLine("Загальні елементи двох масивів без повторень:");
        foreach (int num in combinedArray)
        {
            Console.WriteLine(num);
        }
    }
}
