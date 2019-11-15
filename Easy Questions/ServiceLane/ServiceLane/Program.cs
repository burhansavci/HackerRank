using System;

namespace ServiceLane
{
    class Program
    {
        static int[] serviceLane(int[][] cases, int[] widths)
        {
            var result = new int[cases.Length];
            for (int i = 0; i < cases.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = cases[i][0]; j <= cases[i][1]; j++)
                    if (min > widths[j]) min = widths[j];

                result[i] = min;
            }
            return result;
        }

        static void Main(string[] args)
        {

            string[] nt = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nt[0]);

            int t = Convert.ToInt32(nt[1]);

            int[] widths = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp));


            int[][] cases = new int[t][];

            for (int i = 0; i < t; i++)
            {
                cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            int[] result = serviceLane(cases, widths);

            Console.WriteLine(string.Join("\n", result));

        }
    }
}
