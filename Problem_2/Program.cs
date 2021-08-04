using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String words = "parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray";
            String anagrams = "";
            bool first = true;
            foreach (String x in words.Split(','))
            {
                if (Is_anagram(x))
                {
                    if (first){
                        anagrams += x;
                        first = false;
                    }
                    else {
                        anagrams += ", " + x;
                    }
                }

            }
            
            Console.WriteLine("The Anagrams are the following: " + anagrams);
            Console.ReadLine();
        }

        public static bool Is_anagram(String x)
        {
            if (x.Length==4 && x.Contains("s") && x.Contains("t") && x.Contains("a") && x.Contains("r"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
