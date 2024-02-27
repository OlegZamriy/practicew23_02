using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 9 };

        CountAndDisplay(numbers);
    }

    static void CountAndDisplay(int[] numbers)
    {
        int evenCount = numbers.Count(num => num % 2 == 0);

        int oddCount = numbers.Count(num => num % 2 != 0);

        int uniqueCount = numbers.Distinct().Count();

        Console.WriteLine($"Кількість парних чисел: {evenCount}");
        Console.WriteLine($"Кількість непарних чисел: {oddCount}");
        Console.WriteLine($"Кількість унікальних елементів: {uniqueCount}");
    }
}
