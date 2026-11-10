using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите координату y: ");
            double y = double.Parse(Console.ReadLine());

            // Вычисляем расстояние от центра
            double distance = Math.Sqrt(x * x + y * y);

            string result;

            if (y == -1 && x >= -2 && x <= 2)
            {
                result = "На границе";  // нижняя граница прямоугольника
            }
            else if ((x == -2 || x == 2) && y >= -1 && y <= 0)
            {
                result = "На границе";  // боковые границы прямоугольника
            }
            else if (Math.Abs(distance - 2) < 0.0001 && y >= 0)
            {
                result = "На границе";  // граница полукруга
            }
            else if (x > -2 && x < 2 && y > -1 && y < 0)
            {
                result = "Да";  // внутри прямоугольника
            }
            else if (distance < 2 && y > 0 && y < 2)
            {
                result = "Да";  // внутри полукруга
            }
            else
            {
                result = "Нет";  // снаружи фигуры
            }

            Console.WriteLine();
            Console.WriteLine($"Результат: {result}");
            Console.ReadLine();
        }
    }
}
