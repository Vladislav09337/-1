using SessionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Ошибка: n должно быть натуральным числом!");
                return;
            }

            //Генерация массива (вызов метода из библиотеки)
            int[] numbers = ArrayOperations.GenerateArray(n, -5, 15);
            
            //Вывод массива
            ArrayOperations.PrintArray(numbers);

            //Подсчёт чисел, кратных 3 
            int count3 = ArrayOperations.Count3(numbers);

            //Вычисление суммы произведений соседних элементов
            int sumPr = ArrayOperations.CalculateSumPr(numbers);

            Console.WriteLine($"Количество чисел, кратных 3: {count3}");
            Console.WriteLine($"Сумма произведений соседних элементов: {sumPr}");

            Console.ReadKey();
        }
    }
}


