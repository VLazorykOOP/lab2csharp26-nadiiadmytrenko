using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмірність матриці n (n x n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) return;

        int[,] matrix = new int[n, n];
        Random rnd = new Random();
        Console.WriteLine("\nПочаткова матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.Next(10, 100); 
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        int row1, row2;

        if (n % 2 == 0)
        {
            row1 = n / 2 - 1;
            row2 = n / 2;
            Console.WriteLine($"\nПарна кількість рядків. Міняємо рядок {row1} та {row2}.");
        }
        else
        {
            row1 = 0;
            row2 = n / 2;
            Console.WriteLine($"\nНепарна кількість рядків. Міняємо рядок {row1} та {row2}.");
        }
        for (int j = 0; j < n; j++)
        {
            int temp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = temp;
        }
        Console.WriteLine("\nМатриця після обміну:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

