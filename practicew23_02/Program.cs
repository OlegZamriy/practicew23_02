using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть речення:");
        string sentence = Console.ReadLine();

        int wordCount = CountWords(sentence);
        Console.WriteLine($"Кількість слів у реченні: {wordCount}");
    }

    static int CountWords(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
