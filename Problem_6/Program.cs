using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome checker");
            String x = Console.ReadLine();
            if (x == Reverse(x))
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }
            Console.ReadLine();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
