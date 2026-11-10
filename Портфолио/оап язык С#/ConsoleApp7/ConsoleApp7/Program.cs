using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] A = new int[8];
            int[] B = new int[5];
            int[] C = new int[A.Length];
            int countC = 0;
            Console.Write("A:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(5, 15); 
                Console.Write(" " + A[i]);
            }
            Console.Write("\nB:");
            for (int j = 0; j < B.Length; j++)
            {
                B[j] = rand.Next(0, 41); 
                Console.Write(" " + B[j]);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                {
                    int j = 0;
                    while (j < B.Length && A[i] != B[j])
                    {
                        j++;
                    }
                    if (j == B.Length)
                    {
                        C[countC] = A[i];
                        countC++;
                    }
                }
            }

            Console.Write("\nC:");
            for (int i = 0; i < countC; i++)
            {
                Console.Write(" " + C[i]);
            }

            double pr = 1;
            int count3 = 0;

            for (int i = 0; i < countC; i++)
            {
                if (C[i] % 3 == 0 && C[i] != 0)
                {
                    pr *= C[i];
                    count3++;
                }
            }

            if (count3 > 0)
            {
                double geom = Math.Pow(pr, 1.0 / count3);
                Console.Write($"\nСреднее геометрическое элементов C, кратных трем: {geom:F2}");
            }
            else
            {
                Console.Write("\nВ массиве C нет элементов, кратных трем");
            }

            Console.ReadKey();
        }
    }
}