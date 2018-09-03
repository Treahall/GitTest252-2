using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Hello I am going to think of a posative number.");
            Console.Write("What number do you want the lowerbound to be (no lower than 0): ");
            userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);
            Console.WriteLine();

            Console.Write("What number do you want the upperbound to be: ");
            userInput = Console.ReadLine();
            int y = Convert.ToInt32(userInput);
            Console.WriteLine();

            Console.WriteLine("I am thinking of a number between {0} and {1}.", x, y);

            Random random = new Random(100);
            int Mynum = random.Next(x, y);
            int guess = -1;
            int numTries = 0;

            do
            {
                Console.WriteLine("=========================================================");
                Console.Write("Guess the number: ");
                userInput = Console.ReadLine();

                guess = Convert.ToInt32(userInput);

                if (guess == Mynum)
                    Console.WriteLine("You guessed it right!");
                else if (guess > Mynum)
                    Console.WriteLine("You were too high :(");
                else if (guess < Mynum)
                    Console.WriteLine("You were too low :(");

                numTries++;
            } while (Mynum != guess);

            Console.WriteLine("=========================================================");
            Console.WriteLine("It took you {0} tries", numTries);
            Console.WriteLine("Press any key to exit");

            Console.ReadKey();

        }
    }
}
