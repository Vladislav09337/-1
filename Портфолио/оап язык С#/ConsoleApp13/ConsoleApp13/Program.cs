using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {

string text = "Хороший день"; ​

text = text.Substring(2);       // забираем подстроку начиная с третьего символа​

            Console.WriteLine(text);​
        }
    }
}
