using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and the next prime number will be given:");
            Console.WriteLine("The next prime number is {0}",next_prime_number(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }

        public static int next_prime_number(int prime)
        {
            int next_prime = prime + 1;
            bool found_number = false;
            while (!found_number)
            {
                found_number = Is_prime(next_prime);
                next_prime += 1;
            }
            return next_prime-1;
        }
        public static bool Is_prime(int x)
        {
            if (x == 2) { return true; }
            double z = x;
            int y = Convert.ToInt32(Math.Sqrt(z));
            for(int i = 2;i< y+1;i++)
            {
                if (x%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
