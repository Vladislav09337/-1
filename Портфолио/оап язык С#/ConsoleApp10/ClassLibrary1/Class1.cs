using System;

public static class MathHelper
{
    // Вычисление факториала
    public static long GetFactorial(int number)
    {
        if (number < 0)
            return -1;

        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    // Вычисление числа сочетаний
    public static double GetCombinations(int n, int m)
    {
        // Проверка условия n > m
        if (n <= m) return -1;

        // Вычисляем факториалы
        long factorialN = GetFactorial(n);      // n!
        long factorialM = GetFactorial(m);      // m!
        long factorialNM = GetFactorial(n - m); // (n-m)!

        // ВАЖНО: исправленная формула - n! делится на (m! * (n-m)!)
        double result = (double)factorialN / (factorialM * factorialNM);
        return result;
    }
}