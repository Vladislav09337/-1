using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1.0;
            double epsilon = 0.01;

            // Вычисляем sin(x)
            double sinX = ComputeSin(x, epsilon, "sin(x)");

            // Вычисляем sin(x+3)
            double sinX3 = ComputeSin(x + 3, epsilon, "sin(x+3)");

            // Вычисляем F(x)
            double fraction = sinX / sinX3;
            if (fraction < 0)
            {
                Console.WriteLine("Ошибка: подкоренное выражение отрицательно.");
                return;
            }
            double F = Math.Sqrt(fraction);

            Console.WriteLine($"\nF(x) = {F:F6}");
        }

        static double ComputeSin(double z, double epsilon, string funcName)
        {
            Console.WriteLine($"\nВычисление {funcName}, z = {z:F4}, точность = {epsilon}");
            Console.WriteLine("| № итерации | слагаемое      | сумма         |");

            double sum = 0;
            double term = z; // первый член ряда (i=1)
            int i = 1;

            do
            {
                sum += term;
                Console.WriteLine($"| {i,11} | {term,14:F10} | {sum,14:F10} |");

                // Рекуррентное соотношение для следующего члена
                i++;
                term = -term * z * z / ((2 * i - 2) * (2 * i - 1));

            } while (Math.Abs(term) >= epsilon);

            return sum;
        }
            }
        }
    

                
    

