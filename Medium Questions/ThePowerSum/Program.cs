using System;

namespace ThePowerSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Convert.ToInt32(Console.ReadLine().Trim());

            var n = Convert.ToInt32(Console.ReadLine().Trim());

            var result = powerSum(x, n);

            Console.WriteLine(result);
        }

        private static int powerSum(int x, int n)
        {
            var xRoot = Convert.ToInt32(Math.Floor(Math.Pow(x, 1d / n)));

            var exponentialValues = new int[xRoot];
            for (var i = 1; i <= xRoot; i++)
                exponentialValues[i - 1] = Convert.ToInt32(Math.Pow(i, n));

            return dpApproach(x, exponentialValues);
        }

        private static int dpApproach(int x, int[] exponentialValues)
        {
            var n = exponentialValues.Length;
            var dp = new int[n + 1, x + 1];

            for (var i = 0; i <= n; i++)
                dp[i, 0] = 1;

            for (var col = 1; col <= n; col++)
            {
                for (var row = 1; row <= x; row++)
                    if (exponentialValues[col - 1] > row)
                        dp[col, row] = dp[col - 1, row]; //excluding
                    else
                        dp[col, row] = dp[col - 1, row] + dp[col - 1, row - exponentialValues[col - 1]]; //excluding+including
            }

            return dp[n, x];
        }
    }
}