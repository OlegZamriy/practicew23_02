using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть текст:");
        string inputText = Console.ReadLine();

        Console.WriteLine("Введіть список неприпустимих слів (через кому):");
        string[] forbiddenWords = Console.ReadLine().Split(',');

        int replacementsCount = 0;

        string resultText = FilterText(inputText, forbiddenWords, out replacementsCount);

        Console.WriteLine("Результат:");
        Console.WriteLine(resultText);

        Console.WriteLine($"Статистика: {replacementsCount} замін");
    }

    static string FilterText(string text, string[] forbiddenWords, out int replacementsCount)
    {
        replacementsCount = 0;

        foreach (string word in forbiddenWords)
        {
            text = Regex.Replace(text, @"\b" + word.Trim() + @"\b", m => new string('*', m.Length), RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500));

            replacementsCount += Regex.Matches(text, @"\b" + word.Trim() + @"\b", RegexOptions.IgnoreCase).Count;
        }

        return text;
    }
}
