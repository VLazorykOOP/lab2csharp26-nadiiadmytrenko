using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        double sum = 0;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
            if (array[i] < 0)
            {
                sum += array[i];
                count++;
            }
        }
        if (count > 0)
            Console.WriteLine($"Середнє арифметичне від'ємних: {sum / count}");
        else
            Console.WriteLine("Від'ємних елементів не знайдено.");
    }
}

