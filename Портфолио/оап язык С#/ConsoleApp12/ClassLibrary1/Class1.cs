using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SessionLibrary
{
    public static class ArrayOperations
    {
        // Метод 1: Генерация случайных чисел в массиве на опред. интевале
        public static int[] GenerateArray(int n, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[n];
            int i = 0;

            while (i < n)
            {
                array[i] = random.Next(minValue, maxValue + 1);
                i++;
            }
            return array;
        }

        // Метод 2: Подсчёт чисел, кратных 3
        public static int Count3(int[] array)
        {
            int count = 0;
            int i = 0;

            while (i < array.Length)
            {
                if (array[i] % 3 == 0)
                {
                    count++;
                }
                i++;
            }
            return count;
        }

        // Метод 3: Вычисление суммы произведений соседних элементов
        public static int CalculateSumPr(int[] array)
        {
            int sum = 0;
            int i = 0;

            while (i < array.Length - 1)
            {
                sum += array[i] * array[i + 1];
                i++;
            }
            return sum;
        }

        // Метод 4: Вывод массива на экран
        public static void PrintArray(int[] array)
        {
            Console.Write("Сгенерированный массив: ");
            int i = 0;

            while (i < array.Length)
            {
                Console.Write(array[i] + " ");
                i++;
            }

            Console.WriteLine();
        }
    }
}