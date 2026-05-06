using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        double sum = 0;
        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());

                if (matrix[i, j] < 0)
                {
                    sum += matrix[i, j];
                    count++;
                }
            }
        }
        if (count > 0)
            Console.WriteLine($"\nСереднє арифметичне від'ємних у матриці: {sum / count}");
        else
            Console.WriteLine("\nВід'ємних елементів не знайдено.");
    }
}

