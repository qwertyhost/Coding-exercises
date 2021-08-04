using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Star_triangle(5);
            Console.ReadLine();
        }

        public static void Star_triangle(int row)
        {
            for (int i = 1; i < row+1; i++)
            {
                string x = new string(' ', row -i);
                string y = new string('*', (i*2)-1);

                Console.WriteLine(x+y);
            }
        }


    }
}
