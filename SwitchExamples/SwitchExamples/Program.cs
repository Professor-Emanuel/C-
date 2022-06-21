using System;

namespace SwitchExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Country, wild tigers?");
            string answer = Console.ReadLine();
            int score = Question1(answer);

            TotalPointsScored(score);
            
            /*
            TotalPointsScored(-1);
            TotalPointsScored(4);
            TotalPointsScored(2);
            */
            Console.ReadKey();
        }

        private static int Question1(string answer)
        {
            int score = 0;
            const int bonusPoints = 2;

            switch (answer.ToUpper())
            {
                case "INDIA":
                    score++;
                    Console.WriteLine("Correct");

                    Console.WriteLine("Bonus:");
                    answer = Console.ReadLine();
                    switch(answer.ToUpper())
                    {
                        case "RUSSIA":
                            Console.WriteLine("Correct!! 2 bonuses.");
                            score = score + bonusPoints;
                            break;

                        case "INDONESIA":
                            Console.WriteLine("Incorrect!!!");
                            break;

                        default:
                            Console.WriteLine("Incorrect answer!!! No bonuses.");
                            break;
                    }
                    break;

                case "MALAYSIA":
                case "RUSSIA":
                case "INDONESIA":
                    Console.WriteLine("Incorrect malaysia, russia and indonesia.");
                    break;

                default:
                    Console.WriteLine("Incorrect answer");
                    break;

            }

            return score;
        }

        private static void TotalPointsScored(int score)
        {
            switch (score)
            {
                case 0:
                    Console.WriteLine("You scored '0/3' points");
                    break;
                case 1:
                    Console.WriteLine("You scored '1/3' points");
                    break;
                case 3:
                    Console.WriteLine("You scored '3/3' points");
                    break;

                case int x when x < 0 || x > 3:
                    Console.WriteLine("A score can not be less than 0 or greater than 3");
                    break;

                default:
                    Console.WriteLine("Invalid score");
                    break;
            }

        }
    }
}
