using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть три числа через пробіл:");
        string input = Console.ReadLine();
        int[] sequence = input.Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Введіть масив чисел через пробіл:");
        input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        int count = CountSequenceOccurrences(numbers, sequence);
        Console.WriteLine($"Кількість повторень послідовності: {count}");
    }

    static int CountSequenceOccurrences(int[] numbers, int[] sequence)
    {
        int count = 0;
        for (int i = 0; i <= numbers.Length - sequence.Length; i++)
        {
            bool isMatch = true;
            for (int j = 0; j < sequence.Length; j++)
            {
                if (numbers[i + j] != sequence[j])
                {
                    isMatch = false;
                    break;
                }
            }
            if (isMatch)
                count++;
        }
        return count;
    }
}
