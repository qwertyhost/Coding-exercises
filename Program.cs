using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            bool correct = false;
            Random rnd = new Random();
            int n = rnd.Next(100);
            Console.WriteLine("There is a number between 1 and 99 inclusive and you have 5 goes at guessing it");
            Console.WriteLine("After your guess you will be told if the number is higher or lower than your guess");
            for (int i =1;i<6;i++)
            {
                Console.Write("Guess Number " + i + ": ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > n)
                {
                    Console.WriteLine("Your guess was too high");
                }
                else if(guess < n)
                {
                    Console.WriteLine("Your guess was too low");
                    
                }
                else
                {
                    Console.WriteLine("Your guess was correct");
                    correct = true;
                    break;
                }
                
            }
            if (!correct)
            {
                Console.WriteLine("You have run out of guesses, the correct number was " +n);
            }
            Console.ReadLine();    
        }
    }
}
