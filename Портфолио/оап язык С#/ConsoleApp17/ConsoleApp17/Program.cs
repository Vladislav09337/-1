using System;

class Program
{
    static void Main()
    {
        // Ищем корень на интервале [π/2, 5]
        double left = Math.PI / 2 + 0.01; // чуть больше π/2, чтобы избегать бесконечности
        double right = 5;

        double root = BisectionMethod(left, right, 1e-12, 200);
        Console.WriteLine($"Наименьший положительный корень: x ≈ {root}");
        Console.WriteLine($"Проверка: tan({root}) ≈ {Math.Tan(root)}, разница = {Math.Tan(root) - root}");
    }

    static double Func(double x)
    {
        return Math.Tan(x) - x;
    }

    static double BisectionMethod(double a, double b, double tol, int maxIter)
    {
        double fa = Func(a);
        double fb = Func(b);

        if (fa * fb > 0)
        {
            Console.WriteLine("Нет изменения знака на интервале. Попробуйте другой интервал.");
            return double.NaN;
        }

        double mid = 0;
        for (int i = 0; i < maxIter; i++)
        {
            mid = (a + b) / 2;
            double fmid = Func(mid);

            if (Math.Abs(fmid) < tol)
                return mid;

            if (fa * fmid < 0)
            {
                b = mid;
                fb = fmid;
            }
            else
            {
                a = mid;
                fa = fmid;
            }
        }
        return mid;
    }
}





