using System;

namespace CircularArrayRotation
{
    class Program
    {
        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = a[a.Length - 1];
                int[] arr = new int[a.Length];
                Array.Copy(a, 0, arr, 1, a.Length-1);
                arr[0] = temp;
                a = arr;
            }
            for (int i = 0; i < queries.Length; i++)
            {
                queries[i] = a[queries[i]];
            }
            return queries;
        }

        static void Main(string[] args)
        {

            string[] nkq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nkq[0]);

            int k = Convert.ToInt32(nkq[1]);

            int q = Convert.ToInt32(nkq[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            int[] result = circularArrayRotation(a, k, queries);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadLine();
        }
        #region BruteForceApproach
        //static int[] circularArrayRotation(int[] a, int k, int[] queries)
        //{
        //    for (int i = 0; i < k; i++)
        //    {
        //        int temp = a[a.Length - 1];
        //        for (int j = a.Length - 1; j > 0; j--)
        //        {
        //            a[j] = a[j - 1];
        //        }
        //        a[0] = temp;
        //    }
        //    for (int i = 0; i < queries.Length; i++)
        //    {
        //        queries[i] = a[queries[i]];
        //    }
        //    return queries;
        //}
        #endregion

    }
}
