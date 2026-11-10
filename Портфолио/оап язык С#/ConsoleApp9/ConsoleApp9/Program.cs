using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Бинарный поиск элемента
            int[] arr = { 34, 7, 23, 32, 5, 62, 31, 45, 12, 8 };
            Console.Write("Элемент для бинарного поиска: ");
            int x = int.Parse(Console.ReadLine());

            // Сортируем для бинарного поиска
            Array.Sort(arr);
            int pos = BinarySearch(arr, x);
            Console.WriteLine(pos >= 0 ? $"Найден на позиции {pos + 1}" : "Не найден");

            // 2. Удаление Q элементов с указанной позиции
            Console.Write("\nПозиция для удаления (от 1): ");
            int start = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Сколько удалить (Q): ");
            int q = int.Parse(Console.ReadLine());

            arr = DeleteElements(arr, start, q);

            Console.WriteLine("\nМассив после удаления:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            } 
        }

        static int BinarySearch(int[] a, int x)
        {
            int left = 0, right = a.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (a[mid] == x)
                { 
                    return mid;
                }
                if (a[mid] < x)
                { 
                    left = mid + 1; 
                }
                else
                { 
                    right = mid - 1; 
                }
            }
            return -1;
        }

        static int[] DeleteElements(int[] a, int start, int count)
        {
            int[] newArr = new int[a.Length - count];
            for (int i = 0; i < start; i++)
            {
                newArr[i] = a[i];
            }
            for (int i = start + count; i < a.Length; i++)
            {
                newArr[i - count] = a[i];
            }
            return newArr;
        }
    }
}

