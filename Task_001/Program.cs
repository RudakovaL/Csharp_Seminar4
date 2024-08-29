// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.;

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода: ");
            string input = Console.ReadLine();

            // Проверка на выход
            if (input.ToLower() == "q")
            {
                break;
            }

            // Проверка на целое число
            if (int.TryParse(input, out int number))
            {
                int sumOfDigits = GetSumOfDigits(number);

                // Проверка на четность суммы цифр
                if (sumOfDigits % 2 == 0)
                {
                    Console.WriteLine("Сумма цифр числа четная. Программа завершается.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }
    }

    static int GetSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += Math.Abs(number % 10);
            number /= 10;
        }
        return sum;
    }
}