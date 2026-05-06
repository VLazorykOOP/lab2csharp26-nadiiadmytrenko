using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмірність масиву (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Помилка: введіть коректне ціле число більше нуля.");
            return;
        }
        double[] array = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть елемент [{i}]: ");
            array[i] = double.Parse(Console.ReadLine());
        }
        double minElement = array[0];
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
                minIndex = i;
            }
        }
        Console.WriteLine("\nРезультат");
        Console.WriteLine($"Мінімальний елемент: {minElement}");
        Console.WriteLine($"Індекс (з нуля): {minIndex}");
        Console.WriteLine($"Порядковий номер: {minIndex + 1}");
    }
}
