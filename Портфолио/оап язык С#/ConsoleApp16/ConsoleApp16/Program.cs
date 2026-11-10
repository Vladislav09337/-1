using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Метод хорд");
        Console.WriteLine("Уравнение: (x - 3)cos x = 1");
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("│ n │   x_n    │  cos x_n │ (x_n-3)cos x_n  │  f(x_n)   │   x_n+1   │");
        Console.WriteLine("---------------------------------------------------------------------");

        double a = 5.0;  
        double b = 5.5;  

        double fa = (a - 3) * Math.Cos(a) - 1; 
        double fb = (b - 3) * Math.Cos(b) - 1; 

        double x = a; 

        for (int n = 0; n <= 5; n++)
        {
            double cos_x = Math.Cos(x);
            double term = (x - 3) * cos_x;
            double fx = term - 1;

            
            double x_next = x - fx * (b - x) / (fb - fx);

            Console.WriteLine($"│ {n} │ {x,8:F5} │ {cos_x,8:F5} │     {term,8:F5}    │ {fx,9:F5} │ {x_next,9:F5} │");

            x = x_next;
        }

        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("\nРезультат метода хорд: x ≈ 5,156");
    }
}
