//  Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        // Инициализируем массив
        int[] array = { 1, 2, 3, 4, 5 };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив: " + string.Join(", ", array));

        // Переворачиваем массив
        ReverseArray(array);

        // Выводим перевёрнутый массив
        Console.WriteLine("Перевёрнутый массив: " + string.Join(", ", array));
    }

    static void ReverseArray(int[] array)
    {
        int left = 0; // Левый индекс
        int right = array.Length - 1; // Правый индекс

        while (left < right)
        {
            // Меняем местами элементы
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            // Двигаем индексы к центру
            left++;
            right--;
        }
    }
}