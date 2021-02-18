using System;

namespace HurdleRace
{
    class Program
    {
        static int hurdleRace(int k, int[] height)
        {
            int maxHeight = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > maxHeight)
                    maxHeight = height[i];
            }
            return maxHeight - k >= 0 ? maxHeight - k : 0;
        }

        static void Main(string[] args)
        {

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);

            Console.WriteLine(result);
        }
    }

    #region OtherSolutions1
    //static void Main(String[] args)
    //{
    //    string[] tokens_n = Console.ReadLine().Split(' ');
    //    int n = Convert.ToInt32(tokens_n[0]);
    //    int k = Convert.ToInt32(tokens_n[1]);
    //    string[] height_temp = Console.ReadLine().Split(' ');
    //    int[] height = Array.ConvertAll(height_temp, Int32.Parse);
    //    // your code goes here

    //    var max = height.Max();
    //    var diff = Math.Max(max - k, 0);
    //    Console.WriteLine(diff);
    //}
    #endregion
}
