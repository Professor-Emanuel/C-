using System;

namespace DataTypeConversionExample
{
    class Program
    {

        public struct ImperialMeasurement
        {
            public float feet;

            public ImperialMeasurement(float r)
            {
                this.feet = r;
            }

            //implicit or explicit keyword
            public static implicit operator ImperialMeasurement(int m)
            {
                float conversionResults = 3.28f * m;

                ImperialMeasurement temp = new ImperialMeasurement(conversionResults);

                return temp;
            }
        }
        static void Main(string[] args)
        {
            

            byte a = 255;
            short b = a; //implicit conversion

            short c = 255;
            byte d = Convert.ToByte(c);

            Console.WriteLine($" 'd' = {d}");
            

            float f = 1000.26f;
            int i = Convert.ToInt32(f);
            Console.WriteLine($" f = {f}");
            Console.WriteLine($" i = {i}");

            Console.WriteLine("Please eter an int: ");
            int mm = Convert.ToInt32(Console.ReadLine());

            ImperialMeasurement im = (ImperialMeasurement)mm; //explicit conversion
            ImperialMeasurement imm = mm; //implicit conversion

            Console.WriteLine($"The measurement of {mm} in meter is {im.feet} in feet.");
            Console.WriteLine($"The measurement of {mm} in meter is {imm.feet} in feet.");

            Console.ReadKey();
        }
    }
}
