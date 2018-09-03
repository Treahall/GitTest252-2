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
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am thinking of a number between 1 and 100");
            
            Random random = new Random(100);

            int Mynum = random.Next(0, 100);
            int guess = -1;
            int numTries = 0;

            do
            {
                Console.WriteLine("==========================================");
                Console.Write("Guess the number: ");
                string userInput = Console.ReadLine();

                guess = Convert.ToInt32(userInput);

                if (guess == Mynum)
                    Console.WriteLine("You guessed it right!");
                else if (guess > Mynum)
                    Console.WriteLine("You were too high :(");
                else if (guess < Mynum)
                    Console.WriteLine("You were too low :(");

                numTries++;
            } while (Mynum != guess);

            Console.WriteLine("==========================================");
            Console.WriteLine("It took you '{0}' tries", numTries);
            Console.WriteLine("Press any key to exit");

            Console.ReadKey();

        }
    }
}
