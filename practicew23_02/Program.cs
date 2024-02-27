using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть речення:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        Console.WriteLine("Після перевороту:");
        foreach (string word in words)
        {
            string reversedWord = ReverseString(word);
            Console.Write(reversedWord + " ");
        }
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();

        Array.Reverse(charArray);

        return new string(charArray);
    }
}
