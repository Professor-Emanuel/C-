using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //test average function
            float[] a = { 5.0f, 2.0f, 6.0f, 4.0f };
            float result = 0.0f;
            result = Math.Average(a, 4);
            Console.WriteLine("Average = {0}", result);

            //test totalsumofsquare function
            float SST = 0.0f;
            SST = Math.TotalSumOfSquares(a, 4);
            Console.WriteLine("SST = {0}", SST);

            //test ResidualErrorSumOfSquares
            //assume for now the following array are the predicted values
            float[] predictedValues = { 4.5f, 3.0f, 6.6f, 4.1f };
            float SSE = Math.SumSquaredErrors(a, predictedValues, 4);
            Console.WriteLine("SSE = {0}", SSE);

            //test R2 method
            float R2Coefficient = Math.R2(a, predictedValues, 4);
            Console.WriteLine("R2 = {0}", R2Coefficient);

            //test MSE method
            float S2Coefficient = Math.MeanSquaredError(a, predictedValues, 4);
            Console.WriteLine("S2 = {0}", S2Coefficient);

            Console.ReadLine();
        }
    }
}
