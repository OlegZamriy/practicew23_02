using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть вихідний рядок:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Введіть підрядок для пошуку:");
        string searchString = Console.ReadLine();

        int occurrences = CountOccurrences(inputString, searchString);

        Console.WriteLine($"Результат пошуку: {occurrences}");
    }

    static int CountOccurrences(string inputString, string searchString)
    {
        int count = 0;
        int index = 0;

        while ((index = inputString.IndexOf(searchString, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += searchString.Length;
        }

        return count;
    }
}
