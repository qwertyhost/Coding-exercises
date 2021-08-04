using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Diamond(5);
            Console.ReadLine();
        }

        public static void Star_triangle(int row)
        {
            for (int i = 1; i < row + 1; i++)
            {
                string x = new string(' ', row - i);
                string y = new string('*', (i * 2) - 1);

                Console.WriteLine(x + y);
            }
        }
        public static void Reverse_star_triangle(int row)
        {
            for (int i = 1; i < row; i++)
            {
                string x = new string(' ', i);
                string y = new string('*', ((row-i) * 2) - 1);

                Console.WriteLine(x + y);
            }
        }

        public static void Diamond(int row)
        {
            Star_triangle(row);
            Reverse_star_triangle(row);
        }
    }
}
