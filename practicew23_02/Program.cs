using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть речення:");
        string sentence = Console.ReadLine();

        int vowelCount = CountVowels(sentence);
        Console.WriteLine($"Кількість голосних літер у реченні: {vowelCount}");
    }

    static int CountVowels(string sentence)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        int count = 0;
        foreach (char c in sentence)
        {
            if (Array.IndexOf(vowels, c) != -1)
            {
                count++;
            }
        }
        return count;
    }
}
