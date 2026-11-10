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
            Console.Write("Введите возраст от 1 до 99: ");
            int a = int.Parse(Console.ReadLine());

            if (a < 1 || a > 99)
            {
                Console.WriteLine("Число должно быть от 1 до 99!");
                return;
            }

            Console.Write($"Мне {a}");
            switch (a % 10)
            {
                case 1:
                    if (a % 100 != 11)
                    {
                        Console.WriteLine(" год");
                    }
                    else
                    {
                        Console.WriteLine(" лет");
                    }
                    break;
                case 2:
                case 3:
                case 4:
                    if (a % 100 < 12 || a % 100 > 14)
                    {
                        Console.WriteLine(" года");
                    }
                    else
                    {
                        Console.WriteLine(" лет");
                    }
                    break;
                default:
                    Console.WriteLine(" лет");
                    break;
            }
        }
    }
}




