using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Longest sequence is: {0}", Longest_sequence("1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0"));
            Console.ReadLine();
        }

        public static int Longest_sequence(String x)
        {
            int longest_count = 0;
            int count = 0;
            foreach (char y in x)
            {
                if (y != ',')
                {
                    if (y == '0')
                    {
                        count += 1;
                    }
                    else
                    {
                        if (count > longest_count)
                        {
                            longest_count = count;
                            count = 0;
                        }
                        count = 0;
                    }
                }
            }
            if (count > longest_count)
            {
                longest_count = count;
            }
            return longest_count;
        }
    }
}
