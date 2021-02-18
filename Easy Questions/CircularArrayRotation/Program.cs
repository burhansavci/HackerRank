using System;

namespace CircularArrayRotation
{
    class Program
    {
        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[(i + k) % a.Length] = a[i];
            }
            for (int i = 0; i < queries.Length; i++)
            {
                queries[i] = b[queries[i]];
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

        #region BruteForceApproach1
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
        #region BruteForceApproach2
        //static int[] circularArrayRotation(int[] a, int k, int[] queries)
        //{
        //    for (int i = 0; i < k; i++)
        //    {
        //        int temp = a[a.Length - 1];
        //        int[] arr = new int[a.Length];
        //        Array.Copy(a, 0, arr, 1, a.Length - 1);
        //        arr[0] = temp;
        //        a = arr;
        //    }
        //    for (int i = 0; i < queries.Length; i++)
        //    {
        //        queries[i] = a[queries[i]];
        //    }
        //    return queries;
        //}
        #endregion

        #region OtherSolutions1
        //static void Main(string[] args)
        //{
        //    int n, k, q;
        //    string[] s = Console.ReadLine().Split(' ');
        //    int.TryParse(s[0], out n); int.TryParse(s[1], out k); int.TryParse(s[2], out q);
        //    int[] num = new int[n];
        //    string[] z = Console.ReadLine().Split(' ');
        //    for (int i = 0; i < n; i++)
        //    {
        //        int.TryParse(z[i], out num[i]);
        //    }
        //    while (q-- > 0)
        //    {

        //        int pos = Convert.ToInt32(Console.ReadLine());
        //        k = k % n;
        //        int p = (pos + n - k) % n;
        //        Console.WriteLine(num[p]);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

    }
}
