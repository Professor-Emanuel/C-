using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            //Set application variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Professor Emanuel K.";

            //Change text colour
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}.", appName, appVersion, appAuthor);

            //Reset colour back to white
            //Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();

            //Ask user name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            while (true)
            {
                //Init correct number
                //int correctNumber = 7;
                //create a new random object

                Random random = new Random();
                //generate a random numer from 1 to 10
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10.");

                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a numnber.");
                        Console.ResetColor();
                        continue;
                    }
                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, please try again.");
                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are correct.");
                Console.ResetColor();

                //ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
