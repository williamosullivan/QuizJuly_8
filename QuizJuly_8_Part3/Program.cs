using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizJuly_8_Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            var first = 1 / 1 / 1900;
            var second = 12 / 31 / 2014;

            DateTime low = DateTime.TryParse(first);
            DateTime high = DateTime.TryParse(second);

            if (birthday < low)
            {
                Console.WriteLine("No way you're that old");
            }
            else if (birthday > high)
            {
                Console.WriteLine("You haven't been born yet?");
            }
            else
                Console.WriteLine("Your birthday is " + birthday);
        }
    }
}
