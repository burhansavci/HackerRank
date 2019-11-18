using System;

namespace NewYearChaos
{
    class Program
    {

        static void minimumBribes(int[] q)
        {
            int bribeCounter = 0;
            bool tooChaotic = false;
            for (int i = 0; i < q.Length; i++)
            {
                if ((q[i] - 3) > i)
                {
                    tooChaotic = true;
                    break;
                }

                for (int j = Math.Max(q[i] - 2, 0); j < i; j++)
                {
                    if (q[i] < q[j]) bribeCounter++;
                }

            }

            var result = tooChaotic ? "Too chaotic" : bribeCounter.ToString();
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));

                minimumBribes(q);
            }
            Console.WriteLine();
        }
        #region Other Solutions1
        //static void Main(String[] args)
        //{
        //    int tc = Convert.ToInt32(Console.ReadLine());

        //    for (int ti = 0; ti < tc; ti++)
        //    {
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        int[] a = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);

        //        for (int i = 0; i < n; i++)
        //            a[i]--;

        //        int swap = 0;

        //        for (int j = 0; j < 2; j++)
        //        {
        //            for (int i = n - 1; i > 0; i--)
        //                if (a[i - 1] > a[i])
        //                {
        //                    int t = a[i - 1];
        //                    a[i - 1] = a[i];
        //                    a[i] = t;
        //                    swap++;
        //                }
        //        }

        //        bool chaos = false;
        //        for (int i = 0; i < n; i++)
        //            if (a[i] != i)
        //                chaos = true;

        //        Console.WriteLine(chaos ? "Too chaotic" : ("" + swap));
        //    }
        //}
        #endregion
    }
}
