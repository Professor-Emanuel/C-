using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Giraffe2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            char[] luckyCharacters = { 'a', 'g', 'h', 'c' };
            for(int i=0; i<luckyCharacters.Length; i++)
            {
                Console.WriteLine(luckyCharacters[i]);
            }

            int baseNum = 5;
            int powNum = 4;
            Console.WriteLine("{0}^{1} = {2}.", baseNum, powNum, GetPow(baseNum, powNum));

            // 2D-arrays
            int[,] numberGrid =
            {
                { 1, 2, 3, 4},
                { 5, 6, 7, 8},
                { 9, 10, 11, 12},
                { 13, 14, 15 ,16}
            };

            for(int i=0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    Console.Write("{0} ", numberGrid[i,j]);
                }
                Console.WriteLine();
            }

            int[,] myArray2D = new int[2, 3];

            //exception handling
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine(result);
            }
            catch(Exception e)
            {
                Console.WriteLine("There was an exception error! Wrong: {0}", e.Message);
            }

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Wrong: {0}", e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Wrong: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Final block is optional!");
            }
            */

            // classes & objects
            //Book book1 = new Book("Mike");
            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;

            //Book book2 = new Book("John");
            //book2.title = "Lord of the rings";
            //book2.author = "Tolkein";
            //book2.pages = 700;

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the rings", "Tolkein", 700);
            Console.WriteLine("{0} by {1} has {2}.", book1.title, book1.author, book1.pages);
            Console.WriteLine("{0} by {1} has {2}.", book2.title, book2.author, book2.pages);

            //object methods
            Student s1 = new Student("Emanuel", "Maths", 5.0);
            Student s2 = new Student("Daniel", "Arts", 2.9);
            Console.WriteLine("{0} {1} {2}.", s1.name, s1.major, s1.gpa);
            Console.WriteLine("{0} {1} {2}.", s2.name, s2.major, s2.gpa);

            Console.WriteLine(s1.HasHonors());
            Console.WriteLine(s2.HasHonors());

            //getters and setters
            Movie avengers = new Movie("The Avengers", "JW", "Dog");
            Movie shrek = new Movie("Shrek", "AA", "PG");

            Console.WriteLine(avengers.Rating);
            shrek.Rating = "PG-13";
            Console.WriteLine(shrek.Rating);

            //static atributes
            Console.WriteLine(Movie.movieCount);

            Movie tvd = new Movie("Tvd", "JW", "R");
            Movie sing = new Movie("Sing", "JA", "G");
            Console.WriteLine(Movie.movieCount);
            Console.WriteLine(tvd.getMovieCount());

            UsefulTools.SayHi("Ema");

            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSalad();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.ItalianDish();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }

        //method exponent
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for(int i=0; i<powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }

    }
}
