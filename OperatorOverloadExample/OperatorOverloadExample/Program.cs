using System;

namespace OperatorOverloadExample
{
    class Program
    {
        public class Paralelipiped
        {
            public double Width = 0.0;
            public double Height = 0.0;
            public double Depth = 0.0;

            public Paralelipiped(double w, double h, double d)
            {
                Width = w;
                Height = h;
                Depth = d;
            }

            public static Paralelipiped operator - (Paralelipiped p1, Paralelipiped p2)
            {
                Paralelipiped pResult = new Paralelipiped(p1.Width - p2.Width, p1.Height - p2.Height, p1.Depth - p2.Depth);
                return pResult;
            }

            //look at height to see witch is bigger
            /*public static bool operator > (Paralelipiped p1, Paralelipiped p2)
            {
                if (p1.Height > p2.Height)
                    return true;
                else
                    return false;
            }*/
        }

        public class Rectangle
        {
            public int Width = 0;
            public int Height = 0;

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            //return an Rectangle, overloading + operator
            public static Rectangle operator + (Rectangle rect1, Rectangle rect2)
            {
                Rectangle rectResult = new Rectangle(rect1.Width + rect2.Width, rect1.Height + rect2.Height);
                return rectResult;
            }
        }
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(10, 20);
            Rectangle rect2 = new Rectangle(25, 30);

            Rectangle rectResult = rect1 + rect2;

            Console.WriteLine($"'rect1({rect1.Width}, {rect1.Height})' " +
                $"+ 'rect2({rect2.Width},{rect2.Height})'" +
                $" = 'rectResult({rectResult.Width}, {rectResult.Height})'");

            Paralelipiped p1 = new Paralelipiped(10, 20, 30);
            Paralelipiped p2 = new Paralelipiped(15, 10, 20);

            Paralelipiped p3 = p1 - p2;
            //bool P1P2 = p1 > p2;

            Console.WriteLine($"'p1({p1.Width}, {p1.Height}, {p1.Depth})" +
                $"' - 'p2({p2.Width}, {p2.Height}, {p2.Depth})' = " +
                $"'p3({p3.Width}, {p3.Height}, {p3.Depth})'");
            //Console.WriteLine($"p1 > p2 = {P1P2}");

            Console.ReadKey();
        }
    }
}
