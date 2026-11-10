using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // Создаем два случайных массива
            int[] A = new int[6];
            int[] B = new int[7];

            // Заполняем случайными числами от 0 до 20
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(0, 21);
            }

            for (int i = 0; i < B.Length; i++)
            {
                B[i] = rand.Next(0, 21);
            }

            Console.WriteLine("Массив A (случайный):");
            replacement(A);
            Console.WriteLine("\nМассив B (случайный):");
            replacement(B);
        }

        static void replacement(int[] arr)
        {
            Console.Write("Исходный: ");
            check(arr);

            // Находим первый максимальный элемент
            int max = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[max])
                {
                    max = i;
                }
            }

            // Заменяем все элементы после максимального на 1
            for (int i = max + 1; i < arr.Length; i++)
            {
                arr[i] = 1;
            }

            Console.Write("Результат: ");
            check(arr);
        }

        static void check(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
} 





