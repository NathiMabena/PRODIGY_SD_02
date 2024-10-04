using System;

namespace Guessinggame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int min = 1;
            int max = 120;
            int guess;
            int numtoguess;
            int guesses;
            string res;
            bool playAgain = true;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                numtoguess = random.Next(min, max);

                while (guess != numtoguess)
                {
                    Console.WriteLine("\nI am thinking of a number between 1-120 Guess the number: ");
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());




                        Console.WriteLine("\nGuess: " + guess);

                        if (guess > numtoguess)
                        {
                            Console.WriteLine("\n" + guess + " \nToo High");

                        }

                        else if (guess < numtoguess)
                        {
                            Console.WriteLine("\n" + guess + " Too Low");

                        }

                        guesses++;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number: ");
                    }

                }
                Console.WriteLine("\nNumber: " + numtoguess);
                Console.WriteLine("WINNER");
                Console.WriteLine("It took you " + guesses + " guesses");

                Console.WriteLine("Want to play again? (Y/N): ");
                res = Console.ReadLine();
                res = res.ToUpper();

                if (res == "Y")
                {
                    playAgain = true;
                }

                else if(res == "N") 
                {
                    Console.WriteLine("Thank you for playing chief");
                    playAgain = false;
                }
            }
            

        }
    }
}
