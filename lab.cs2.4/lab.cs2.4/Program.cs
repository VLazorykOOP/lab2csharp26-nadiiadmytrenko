using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків n: ");
        int n = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[n][];
        int maxCols = 0;
        Random rnd = new Random(); Console.WriteLine("\nЗгенерований східчастий масив:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у рядку {i}: ");
            int m = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[m];

            if (m > maxCols) maxCols = m;
            for (int j = 0; j < m; j++)
            {
                jaggedArray[i][j] = rnd.Next(-10, 20);
                Console.Write(jaggedArray[i][j] + "\t");
            }
            Console.WriteLine();
        }
        List<int> resultList = new List<int>();

        for (int j = 0; j < maxCols; j++)
        {
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (j < jaggedArray[i].Length)
                {
                    if (jaggedArray[i][j] > 0)
                    {
                        resultList.Add(jaggedArray[i][j]);
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
            {

            }
        }
        int[] resultArray = resultList.ToArray();

        Console.WriteLine("\nНовий масив (перші додатні елементи стовпців):");
        if (resultArray.Length > 0)
        {
            Console.WriteLine(string.Join(", ", resultArray));
        }
        else
        {
            Console.WriteLine("Додатніх елементів не знайдено.");
        }
    }
}
