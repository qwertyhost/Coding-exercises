using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int count = 0;
            Console.Write("Position : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (true)
            {
                num++;

                if (Is_prime(num))
                {
                    count++;
                    if (count == n)
                    {
                        Console.WriteLine("The prime number at position {0} is {1}",n,num);
                        break;
                    }
                }
                
            }
            Console.ReadLine();
        }

        public static bool Is_prime(int x)
        {
            if (x == 2) { return true; }
            double z = x;
            int y = Convert.ToInt32(Math.Sqrt(z));
            for (int i = 2; i < y + 1; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
