using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПРОСТОЙ КАЛЬКУЛЯТОР СИНУСА");
            Console.Write("Введите число X: ");
            double x = double.Parse(Console.ReadLine());
            double e = 0.01;
            double sum = 0.0; 
            double term;         // текущее слагаемое
            int step = 1; 
            term = x;
            sum = term;
            Console.WriteLine("+-------+------------------+------------------+");
            Console.WriteLine("| Шаг   | Слагаемое        | Сумма            |");
            Console.WriteLine("+-------+------------------+------------------+");
            Console.WriteLine($"|   1   | {term,16:F6} | {sum,16:F6} |");
            step = 2;
            do
            {
                // новое = -старое * x * x / ((2*step-1) * (2*step-2))
                term = -term * x * x / ((2 * step - 1) * (2 * step - 2));
                sum += term;
                Console.WriteLine($"|   {step}   | {term,16:F6} | {sum,16:F6} |");
                step++; 
            } while (Math.Abs(term) >= e);
            Console.WriteLine("+-------+------------------+------------------+");
            Console.WriteLine();
            Console.WriteLine($"Наше вычисленное значение = {sum:F6}");
            Console.WriteLine($"Потребовалось шагов: {step - 1}");


        }
    }
}
