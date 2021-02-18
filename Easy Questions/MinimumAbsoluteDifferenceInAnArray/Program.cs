using System;

namespace MinimumAbsoluteDifferenceInAnArray
{
    class Program
    {
        public static int minumumAbsDifference(int[] arr)
        {
            int minAbsDif = int.MaxValue;

            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) < minAbsDif)
                {
                    minAbsDif = Math.Abs(arr[i] - arr[i + 1]);
                }
            }

            return minAbsDif;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Console.WriteLine(minumumAbsDifference(arr));
        }
    }
}
