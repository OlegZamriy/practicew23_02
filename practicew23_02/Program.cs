using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть арифметичний вираз (тільки + і -):");
        string input = Console.ReadLine();

        double result = CalculateExpression(input);
        Console.WriteLine("Результат: " + result);
    }

    static double CalculateExpression(string input)
    {
        double result = 0;
        char currentOperator = '+';
        int currentIndex = 0;

        while (currentIndex < input.Length)
        {
            int nextOperatorIndex = input.IndexOfAny(new char[] { '+', '-' }, currentIndex);
            if (nextOperatorIndex == -1)
            {
                nextOperatorIndex = input.Length;
            }

            double operand = double.Parse(input.Substring(currentIndex, nextOperatorIndex - currentIndex));

            if (currentOperator == '+')
            {
                result += operand;
            }
            else if (currentOperator == '-')
            {
                result -= operand;
            }

            if (nextOperatorIndex < input.Length)
            {
                currentOperator = input[nextOperatorIndex];
                currentIndex = nextOperatorIndex + 1;
            }
            else
            {
                break;
            }
        }

        return result;
    }
}
