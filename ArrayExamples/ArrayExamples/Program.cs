using System;

namespace ArrayExamples
{
    class Program
    {
        static void OneDimArray()
        {
            int[] grades = new int[4];
            grades[0] = 57;
            grades[1] = 70;
            grades[2] = 20;
            grades[3] = 90;

            PrintArray1D(grades);
        }

        static void PrintArray1D(int[] array)
        {
            for (int count = 0; count <= array.Length - 1; count++)
            {
                Console.WriteLine($"{array[count]}");
            }
        }

        static void TwoDimArray()
        {
            int[,] studentGrade = new int[4, 3];
            studentGrade[0, 0] = 54;
            studentGrade[0, 1] = 70;

            studentGrade[1, 0] = 90;
            studentGrade[1, 1] = 71;

            PrintArray2D(studentGrade);
        }

        static void PrintArray2D(int[,] array)
        {
            for(int i = 0; i <= array.GetLength(0) - 1; i++)
            {
                for(int j=0; j <= array.GetLength(1) - 1; j++)
                {
                    Console.Write($"{array[i,j]} \t");
                }
                Console.WriteLine();
            }
        }

        static void ThreeDimArray()
        {
            int[,,] studentGrade = new int[2, 4, 3];
            studentGrade[0, 0, 0] = 55;
            studentGrade[0, 0, 1] = 70;
            studentGrade[0, 0, 2] = 56;

            studentGrade[0, 1, 0] = 90;
            studentGrade[0, 1, 1] = 75;
            studentGrade[0, 1, 2] = 66;

            studentGrade[0, 2, 0] = 91;
            studentGrade[0, 2, 1] = 71;
            studentGrade[0, 2, 2] = 61;

            studentGrade[0, 3, 0] = 13;
            studentGrade[0, 3, 1] = 13;
            studentGrade[0, 3, 2] = 13;

            studentGrade[1, 0, 0] = 25;
            studentGrade[1, 0, 1] = 20;
            studentGrade[1, 0, 2] = 26;

            studentGrade[1, 1, 0] = 30;
            studentGrade[1, 1, 1] = 35;
            studentGrade[1, 1, 2] = 36;

            studentGrade[1, 2, 0] = 41;
            studentGrade[1, 2, 1] = 41;
            studentGrade[1, 2, 2] = 41;

            studentGrade[1, 3, 0] = 53;
            studentGrade[1, 3, 1] = 53;
            studentGrade[1, 3, 2] = 53;

            PrintArray3D(studentGrade);
        }

        static void PrintArray3D(int[,,] array)
        {
            for (int i = 0; i <= array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= array.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k <= array.GetLength(2) - 1; k++)
                    {
                        Console.Write($"{array[i, j, k]} \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
            }
        }

        static void JaggedArray()
        {
            int[][] studentGrades = new int[4][];
            studentGrades[0] = new int[3] { 50, 70, 54 };
            studentGrades[1] = new int[2] { 53, 65 };
            studentGrades[2] = new int[2] { 50, 60 };
            studentGrades[3] = new int[1] { 73 };

            PrintJaggedArray(studentGrades);

        }

        static void PrintJaggedArray(int[][] array)
        {
            for(int x=0; x<=array.Length - 1; x++)
            {
                for(int y=0; y<= array[x].Length - 1; y++)
                {
                    Console.Write($"{array[x][y]} \t");
                }
                Console.WriteLine();
            }
        }

        public class LondonTaxiCab : Vehicle
        {
            const int numPeopleCanCarry = 7;
            public override string Name
            {
                get
                {
                    return "Taxi";
                }
            }

            public override VehicleType GetVehicleType()
            {
                return VehicleType.Land;
            }

            public override string GetDescription()
            {
                return base.GetDescription() + Environment.NewLine + "London Taxi Cab";
            }

            public override int GetNumPeopleCanCarry()
            {
                return numPeopleCanCarry;
            }
        }
        public abstract class Vehicle
        {
            private int _numPeopleCanCarry = 4;
            private string _description = "People carrying vehicle";

            public enum VehicleType
            {
                Land, 
                Water,
                Air
            }

            public Vehicle()
            {


            }

            public abstract string Name { get; }

            public abstract VehicleType GetVehicleType();

            public virtual string GetDescription()
            {
                return _description;
            }

            public virtual int GetNumPeopleCanCarry()
            {
                return _numPeopleCanCarry;
            }

        static void Main(string[] args)
        {
            OneDimArray();
            TwoDimArray();
            ThreeDimArray();
            JaggedArray();
        }
    }
}
