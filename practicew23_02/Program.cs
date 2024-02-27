using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть текст:");
        string inputText = Console.ReadLine();

        string resultText = ChangeCaseOfFirstLetter(inputText);
        Console.WriteLine("Результат:");
        Console.WriteLine(resultText);
    }

    static string ChangeCaseOfFirstLetter(string text)
    {
        string pattern = @"(?<=\.|\?|\!)\s+";
        string[] sentences = Regex.Split(text, pattern);

        for (int i = 0; i < sentences.Length; i++)
        {
            if (!string.IsNullOrWhiteSpace(sentences[i]))
            {
                sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
            }
        }

        string result = string.Join(" ", sentences);
        return result;
    }
}
