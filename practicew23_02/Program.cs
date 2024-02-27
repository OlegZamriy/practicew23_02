using System;

class Program
{
    static void Main(string[] args)
    {
        double[] A = new double[5];
        Console.WriteLine("Введіть елементи масиву А:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            A[i] = Convert.ToDouble(Console.ReadLine());
        }

        double[,] B = new double[3, 4];
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = random.NextDouble() * 100; 
            }
        }

        Console.Write("Масив А: ");
        foreach (var item in A)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Масив В:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

        double maxA = A[0];
        double maxB = B[0, 0];
        foreach (var item in A)
        {
            if (item > maxA)
                maxA = item;
        }
        foreach (var item in B)
        {
            if (item > maxB)
                maxB = item;
        }
        double globalMax = Math.Max(maxA, maxB);
        Console.WriteLine("Загальний максимальний елемент: " + globalMax);

        double minA = A[0];
        double minB = B[0, 0];
        foreach (var item in A)
        {
            if (item < minA)
                minA = item;
        }
        foreach (var item in B)
        {
            if (item < minB)
                minB = item;
        }
        double globalMin = Math.Min(minA, minB);
        Console.WriteLine("Загальний мінімальний елемент: " + globalMin);

        double sumA = 0;
        double sumB = 0;
        foreach (var item in A)
        {
            sumA += item;
        }
        foreach (var item in B)
        {
            sumB += item;
        }
        double totalSum = sumA + sumB;
        Console.WriteLine("Загальна сума усіх елементів: " + totalSum);

        double productA = 1;
        double productB = 1;
        foreach (var item in A)
        {
            productA *= item;
        }
        foreach (var item in B)
        {
            productB *= item;
        }
        double totalProduct = productA * productB;
        Console.WriteLine("Загальний добуток усіх елементів: " + totalProduct);

        double sumEvenA = 0;
        foreach (var item in A)
        {
            if (item % 2 == 0)
                sumEvenA += item;
        }
        Console.WriteLine("Сума парних елементів масиву А: " + sumEvenA);

        double sumOddColumnsB = 0;
        for (int j = 0; j < 4; j++)
        {
            if (j % 2 != 0) 
            {
                for (int i = 0; i < 3; i++)
                {
                    sumOddColumnsB += B[i, j];
                }
            }
        }
        Console.WriteLine("Сума непарних стовпців масиву В: " + sumOddColumnsB);
    }
}
