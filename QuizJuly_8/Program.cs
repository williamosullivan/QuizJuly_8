using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizJuly_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int length = array.Length;
            int k = 0;
            while (k < length)
            {
                if (array[k] % 2 == 0)
                {
                    Console.WriteLine(array[k]);
                }
                k++;
            }
            Console.ReadLine();
        }
    }
}
