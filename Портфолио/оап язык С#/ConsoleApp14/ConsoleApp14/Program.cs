using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "(первая подстрока) ялялялял (вторая подстрока) еще текст третья)";
            Regex regex = new Regex(@"\(([^)]+)\)");
            MatchCollection mat = regex.Matches(text);

            Console.WriteLine("Найденные подстроки:");
            for (int i = 0; i < mat.Count; i++)
            {
                Console.WriteLine(mat[i].Groups[2]);

            }
        }
    }
}
