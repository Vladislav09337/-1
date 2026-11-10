using System;

class Program
{
    // Подынтегральная функция из задания 1
    static double f(double x)
    {
        return 0.37 * Math.Exp(Math.Sin(x));
    }

    // Метод Симпсона
    static double Simpson(double a, double b, int n)
    {
        double h = (b - a) / n;
        double S = f(a) + f(b);

        for (int i = 1; i < n; i++)
        {
            double x = a + i * h;
            S += (i % 2 == 0) ? 2 * f(x) : 4 * f(x);
        }

        return S * h / 3.0;
    }

    static void Main(string[] args)
    {
        double a = 0;
        double b = 1;
        double eps = 1e-6;

        int n = 10;
        double I_prev, I_curr;

        I_curr = Simpson(a, b, n);

        do
        {
            I_prev = I_curr;
            n *= 2;
            I_curr = Simpson(a, b, n);
        }
        while (Math.Abs(I_curr - I_prev) > eps);

        Console.WriteLine($"Значение интеграла: {I_curr:F8}");
        Console.WriteLine($"Число разбиений: {n}");
    }
}