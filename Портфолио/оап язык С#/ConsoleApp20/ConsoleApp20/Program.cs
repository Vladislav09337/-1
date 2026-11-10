using System;

class Program
{
    // Функция f(x, y) = x*y^3 - x^2 (вариант 1)
    static double f(double x, double y)
    {
        return x * Math.Pow(y, 3) - Math.Pow(x, 2);
    }

    static void Main(string[] args)
    {
        double x0 = 4.0;     // Текущее значение x
        double y0 = 0.7;     // Текущее значение y
        double h = 0.1;      // Шаг интегрирования
        double b = 5.0;      // Конец отрезка интегрирования

        Console.Write($"Начальное значение x0: {x0}");
        Console.Write($"\nНачальное значение y0: {y0}");
        Console.Write($"\nШаг интегрирования h: {h}");
        Console.Write($"\nКонец отрезка b: {b}");

        double x = x0;       // Текущий x (начинаем с x0)
        double y = y0;       // Текущий y (начинаем с y0)

        // Переменные для метода Коши
        double k1;           // f(x_i, y_i)
        double y_pred;       // y_пред - предположительный y
        double k2;           // f(x_(i+1), y_пред)

        Console.WriteLine("\nМетод Эйлера-Коши:");
        Console.WriteLine("┌──────┬──────────────┬──────────────────────┬──────────────────────┬──────────────────────┐");
        Console.WriteLine("│  i   │      x       │          y           │       y_пред         │     f(x+1,y_пред)    │");
        Console.WriteLine("├──────┼──────────────┼──────────────────────┼──────────────────────┼──────────────────────┤");

        int i = 0;

        // Метод Коши использует формулу:
        // y_(i+1) = y_i + h * [f(x_i, y_i) + f(x_(i+1), y_пред)] / 2
        // где y_пред = y_i + h * f(x_i, y_i)

        while (x <= b + h / 2 && !double.IsInfinity(y) && !double.IsNaN(y))
        {
            // Выводим текущие значения x и y
            Console.WriteLine($"│{i,6}│{x,14:F2}│{FormatNumber(y),22}│{' ',-22}│{' ',-22}│");

            // Вычисляем k1 = f(x_i, y_i)
            k1 = f(x, y);

            // Предположительный y
            // y_пред = y_i + h * f(x_i, y_i)
            y_pred = y + h * k1;

            // Вычисляем k2 = f(x_(i+1), y_пред)
            // x_(i+1) = x_i + h
            if (x < b)
            {
                k2 = f(x + h, y_pred);
            }
            else
            {
                k2 = 0; // Для последней точки k2 не используется
            }

            // y_(i+1) = y_i + h * (k1 + k2) / 2
            y = y + h * (k1 + k2) / 2;

            // Увеличиваем x на шаг h
            x = x + h;
            i++;

            // Выводим
            Console.WriteLine($"│{' ',-6}│{' ',-14}│{' ',-22}│{FormatNumber(y_pred),22}│{FormatNumber(k2),22}│");
        }

        // Закрываем таблицу
        Console.WriteLine("└──────┴──────────────┴──────────────────────┴──────────────────────┴──────────────────────┘");
        Console.WriteLine("\n⚠️  ВНИМАНИЕ: Решение уходит в бесконечность!");
    }

    static string FormatNumber(double value)
    {
        if (double.IsInfinity(value) || double.IsNaN(value) || Math.Abs(value) > 1e100)
            return "∞";
        if (Math.Abs(value) > 1e10)
            return value.ToString("E6");
        return value.ToString("F6");
    }
}