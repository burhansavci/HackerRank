using System;

namespace EqualizeTheArray
{
    class Program
    {
        static int equalizeArray(int[] arr)
        {
            int notToDeleteCounter = 0;
            int counterKeeper = 0;
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] == arr[i - 1])
                {
                    notToDeleteCounter++;

                    if (notToDeleteCounter > counterKeeper)
                        counterKeeper = notToDeleteCounter;
                }
                else
                    notToDeleteCounter = 0;
            }
            return arr.Length - (counterKeeper + 1);
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int result = equalizeArray(arr);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        #region Other Solutions1
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] a = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);

        //    int len = 101;
        //    int[] f = new int[len];

        //    for (int i = 0; i < n; i++)
        //        f[a[i]]++;

        //    int max = 0;

        //    for (int i = 0; i < len; i++)
        //        if (f[i] > max)
        //        {
        //            max = f[i];
        //        }

        //    Console.WriteLine(n - max);
        //}
        #endregion
        #region Other Solutions2
        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).GroupBy(i => i).Select(g => g.Count()).OrderByDescending(i => i).First();
        //    Console.WriteLine(n - numbers);
        //}
        #endregion
    }
}
