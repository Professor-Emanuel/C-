using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    //class containing mathematical computations for linear regression, using method of least squares.
    public class Math
    {
        //return the arithmetic mean of an array of numbers
        public static float Average(float[] data, int length)
        {
            float total = 0;
            foreach(float num in data)
            {
                total += num;
            }

            return (total / length);
        }

        //square the difference between observed value and average and sum them all up
        public static float TotalSumOfSquares(float[] ObservedY, int length)
        {
            float residuals = 0.0f;
            float total = 00.0f;
            float yAverage = Average(ObservedY, length);

            foreach (float num in ObservedY)
            {
                residuals = num - yAverage;
                total += (residuals * residuals);
            }

            return total;
        }

        //SSE = Sum of Squared Errors
        //square the difference between observed value and predicted value and sum them all up
        public static float SumSquaredErrors(float[] ObservedY, float[] PredictedY, int length)
        {
            float total = 0.0f;
            float error = 0.0f;
            for(int i=0; i<ObservedY.Length; i++)
            {
                error = ObservedY[i] - PredictedY[i];
                total += (error * error);
            }

            return total;
        }

        //compute the coefficient of determination for goodness of fit of the regression
        public static float R2(float[] ObservedY, float[] PredictedY, int length)
        {
            float SSE = SumSquaredErrors(ObservedY, PredictedY, length);
            float SST = TotalSumOfSquares(ObservedY, length);

            return ( 1 - (SSE / SST));
        }

        //MSE = mean squared error (length - degrees of freedom n - p; p = number of estimators)
        //p = 2, in case of simple linear regression, we estimate the slope and intecept, thus the 2;
        public static float MeanSquaredError(float[] ObservedY, float[] PredictedY, int length)
        {
            return SumSquaredErrors(ObservedY, PredictedY, length) / (length - 2);
        }
    }
}
