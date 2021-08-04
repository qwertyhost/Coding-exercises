using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (x != 0)
            {
                sum += x % 10;
                x /= 10;
            }
            Console.WriteLine("The sum of the digits of the number is {0}", sum);
            Console.ReadLine();
        }
    }
}
