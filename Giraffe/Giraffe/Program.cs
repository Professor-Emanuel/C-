using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        //region Main method
        static void Main(string[] args)
        {
            /*
            string characterName = "John";
            int characterAge = 35;
            char grade = 'A';
            float f = 10.01f;
            double d = 11.11;
            decimal de = 12.124m;
            bool isMale = false;
            Boolean b = true;

            Console.WriteLine("Hello, " + characterName + ". How are you?");
            Console.WriteLine("What is your age?");
            Console.WriteLine("John: My age is "+ characterAge +".");

            string phrase = "I am" + " cool!" + " This is " + b;
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("ams"));

            for(int i=0; i<phrase.Length; i++)
            {
                Console.WriteLine(phrase[i]);
            }

            Console.WriteLine(phrase.IndexOf('a'));
            Console.WriteLine(phrase.IndexOf("am"));
            Console.WriteLine(phrase.Substring(5));
            Console.WriteLine(phrase.Substring(5, 4));
            Console.WriteLine("Using foreach!");
            */

            /*foreach (var in phrase)
            {
                Console.WriteLine(var);
            }*/

            /*
            //numbers
            Console.WriteLine(-4.35);
            Console.WriteLine( 5 + 8 );
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(6));

            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            */

            /*
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
            */

            /*
            //Arrays
            int[] lNr = { 1, 78, 98, 101, 928, 100};
            for(int i=0; i<lNr.Length; i++)
            {
                Console.WriteLine(lNr[i]);
            }

            lNr[2] = -19;
            lNr[5] = -91;

            foreach (int var in lNr)
            {
                Console.WriteLine(var);
            }

            //if we don't populate the array we need to tell C# how many elements the array should have
            string[] friends = new string[6];
            friends[0] = "Jon";
            friends[1] = "Jim";

            foreach(string var in friends)
            {
                Console.WriteLine(var);
            }
            */

            /*
            //Methods
            SayHi();
            SayHi2("Ema");
            SayHi3("Ema", 30, 'm');

            int num = 10;
            Console.WriteLine(Cube(num));

            int cubedNr = Cube(5);
            Console.WriteLine(cubedNr);
            */

            /*
            //if statements
            bool isMale = false;
            bool isTall = false;
            if (isMale && isTall)
            {
                Console.WriteLine("I am a male and I am tall");
            }
            else if(isMale && !isTall)
            {
                Console.WriteLine("I am a male and I am not tall");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("I am not male, but I am tall");
            }
            else
            {
                Console.WriteLine("I am not male and I am not tall");
            }

            Console.WriteLine(GetMax(10, -10));
            Console.WriteLine(GetMax3(10, -10, 5));
            Console.WriteLine(GetMax3(-10, -10, 5));
            Console.WriteLine(GetMax3(1, 10, -10));
            Console.WriteLine(GetMax3(10, 10, 10));
            */

            /*
            //Calculator
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator: ");
            string op = Console.ReadLine();
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if ( op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if( op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid operator!");
            }
            */

            //Switch Statement
            //Console.WriteLine(GetDay(10));

            /*
            //While loops and do-while loops
            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("Do loop:");
            int index2 = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
            */

            /*
            //Guessing Game
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while ((guess != secretWord) && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }
            Console.WriteLine();

            string secretWord2 = "Ema";
            string guessWord2 = "";
            int guessCount2 = 0;
            int guessLimit2 = 3;
            bool outOfGuesses2 = false;

            do
            {
                if (guessCount2 < guessLimit2)
                {
                    Console.Write("Enter guess: ");
                    guessWord2 = Console.ReadLine();
                    guessCount2++;
                }
                else
                {
                    outOfGuesses2 = true;
                }
            } while (!outOfGuesses2 && !(guessWord2 == secretWord2));


            if (!outOfGuesses2)
            {
                Console.WriteLine("WINNER");
            }
            else
            {
                Console.WriteLine("LOSER");
            }
            */



            Console.ReadLine();
        }



        //end region Main method

        /*
        //region Methods
        static void SayHi()
        {
            Console.WriteLine("Hello user");
        }

        static void SayHi2(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void SayHi3(string name, int age, char gender)
        {
            Console.WriteLine("Hello " + name + ". You are " + age + " and have gender: " + gender);
        }

        static int Cube(int number)
        {
            return number * number * number;
        }
        

        static int GetMax(int num1, int num2)
        {
            int result;
            if(num1 > num2)
            {
                Console.WriteLine("Num1 is bigger than num2!");
                result = num1;
            } 
            else if(num1 == num2)
            {
                Console.WriteLine("Num1 is equal to num2");
                result = num1;
            }
            else
            {
                Console.WriteLine("Num2 is bigger than num1");
                result = num2;
            }
            return result;
        }

        static int GetMax3(int num1, int num2, int num3)
        {
            int result;
            if(num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
        //end region
        */

        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid day number.";
                    break;
            }

            return dayName;
        }

    }
}
