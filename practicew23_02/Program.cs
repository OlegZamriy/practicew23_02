using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Введіть число, порівняння з яким ви хочете зробити:");
        int threshold = Convert.ToInt32(Console.ReadLine());

        int count = CountValuesBelowThreshold(numbers, threshold);
        Console.WriteLine($"Кількість значень у масиві менше {threshold}: {count}");
    }

    static int CountValuesBelowThreshold(int[] numbers, int threshold)
    {
        int count = numbers.Count(num => num < threshold);
        return count;
    }
}
