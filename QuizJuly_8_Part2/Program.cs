using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizJuly_8_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Stuff = new List<string> {"Stuff", "MoreStuff", "EvenMore", "lots", "of", "junk"};
            foreach (var item in Stuff)
            {
                int num = 5;
                int n = 0;
                while (n <= num)
                {
                    Console.WriteLine(item);
                    n++;
                }
            }
        }
    }
}
