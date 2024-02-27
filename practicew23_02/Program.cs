using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть рядок для шифрування:");
        string originalText = Console.ReadLine();

        Console.WriteLine("Введіть ключ шифрування (ціле число):");
        int key = Convert.ToInt32(Console.ReadLine());

        string encryptedText = Encrypt(originalText, key);
        Console.WriteLine($"Зашифрований текст: {encryptedText}");

        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine($"Розшифрований текст: {decryptedText}");
    }

    static string Encrypt(string input, int key)
    {
        string result = "";
        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
            {
                char shiftedChar = (char)(((ch - 'A' + key) % 26) + 'A');
                result += shiftedChar;
            }
            else
            {
                result += ch;
            }
        }
        return result;
    }

    static string Decrypt(string input, int key)
    {
        return Encrypt(input, 26 - key);
    }
}
