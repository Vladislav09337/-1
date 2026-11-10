using System;

class NewtonInterpolation
{
    static void Main()
    {
        // Исходные данные
        double[] x = { 0.65, 0.70, 0.75 };
        double[] y = { 0.60519, 0.64422, 0.68164 };

        // Конечные разности
        double dy0 = y[1] - y[0];           // Δy₀
        double d2y0 = y[2] - 2 * y[1] + y[0]; // Δ²y₀

        double h_step = 0.05;  // исходный шаг
        double newStep = 0.01; // шаг уплотнения

        // Границы интервала уплотнения
        double a = 0.65;  // левая граница
        double b = 0.75;  // правая граница

        Console.WriteLine("Уплотнённая таблица на отрезке [0.65; 0.75]");
        Console.WriteLine("   x\t\t P(x)");
        Console.WriteLine("----------------------");

        for (double x0 = a; x0 <= b + 0.0001; x0 += newStep)
        {
            // Проверяем, есть ли уже узел в исходной таблице
            bool isOriginal = false;
            double originalValue = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (Math.Abs(x0 - x[i]) < 0.0001)
                {
                    isOriginal = true;
                    originalValue = y[i];
                    break;
                }
            }

            if (isOriginal)
            {
                Console.WriteLine($"{x0:F2}\t\t {originalValue:F6} (исходный)");
            }
            else
            {
                double q = (x0 - x[0]) / h_step;
                double p = y[0] + q * dy0 + (q * (q - 1) / 2) * d2y0;
                Console.WriteLine($"{x0:F2}\t\t {p:F6}");
            }
        }
    }
}

