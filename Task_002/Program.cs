// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[10]; // массив из 10 элементов

        // Заполнение массива случайными трехзначными числами
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        // Подсчет четных чисел
        int evenCount = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0) // проверка на четность
            {
                evenCount++;
            }
        }

        // Вывод результата
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }
}
