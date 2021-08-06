using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = 6;
            int index = 0;
            String wordsofar = "";
            String guess = "";
            String letter = "";
            int n = rnd.Next(10);
            List<string> optionList = new List<string> { "hello", "read", "fall", "light","string", "hang", "block", "potato", "raise", "catch" };
            String word = optionList[n];
            String word1 = optionList[n];
            ArrayList list = new ArrayList();

            for (int i=0;i<word.Length;i++)
            {
                list.Add("-");
            }

            foreach (String x in list)
            {
                wordsofar += x;
            }

            Console.WriteLine("This is a hangman game where you have 6 chances to guess the word. You can only enter a single letter");
            

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("The word guessed so far is " + wordsofar + ". You have " + num +" guesses remaining. The following letters have been guessed:" + guess);
                letter = Console.ReadLine();
                if (letter.Length != 1)
                {
                    Console.WriteLine("Please only enter a single letter");
                }
                else
                {
                    guess += " " + letter;
                    while (word.Contains(letter))
                    {
                        index = word.IndexOf(Convert.ToChar(letter));

                        StringBuilder sb1 = new StringBuilder(wordsofar);
                        sb1[index] = Convert.ToChar(letter); // index starts at 0!
                        wordsofar = sb1.ToString();

                        StringBuilder sb = new StringBuilder(word);
                        sb[index] = '.'; // index starts at 0!
                        word = sb.ToString();

                    }
                    if (!wordsofar.Contains('-'))
                    {
                        Console.WriteLine("You have correctly guessed the word as " + wordsofar);
                        break;
                    }
                   
                }

                num -= 1;
            }
            if (wordsofar.Contains('-'))
            {
                Console.WriteLine("You have failed to guess the word " + word1);
            }

            Console.ReadLine();
        }
    }
}
