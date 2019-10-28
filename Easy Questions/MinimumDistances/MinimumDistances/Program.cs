using System;
using System.Linq;

namespace MinimumDistances
{
    class Program
    {
        static int minimumDistances(int[] a)
        {
            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j] && i != j && Math.Abs(i - j) < min)
                    {
                        min = Math.Abs(i - j);
                    }
                }
            }
            if (min == int.MaxValue)
            {
                return -1;
            }
            else
            {
                return min;
            }

        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int result = minimumDistances(a);

            Console.WriteLine(result);
            Console.ReadKey();
        }
        #region Other Solutions1
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] A_temp = Console.ReadLine().Split(' ');
        //    int[] A = Array.ConvertAll(A_temp, Int32.Parse);

        //    int d = -1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (i == j) continue;
        //            if (A[i] == A[j])
        //            {
        //                int tmp = Math.Abs(i - j);
        //                if (d == -1) d = tmp;
        //                else if (tmp < d) d = tmp;
        //            }
        //        }
        //    }

        //    Console.WriteLine(d);
        //}
        #endregion
        #region Other Solutions2
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] A_temp = Console.ReadLine().Split(' ');
        //    int[] a = Array.ConvertAll(A_temp, Int32.Parse);

        //    int[] z = new int[n];

        //    for (int i = 0; i < n; i++)
        //        z[i] = i;

        //    Array.Sort(a, z);

        //    int min = int.MaxValue;

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (a[i] == a[i - 1] && Math.Abs(z[i] - z[i - 1]) < min)
        //        {
        //            min = Math.Abs(z[i] - z[i - 1]);
        //        }
        //    }

        //    Console.WriteLine(min < int.MaxValue ? min : -1);
        //}
        #endregion
    }
}
