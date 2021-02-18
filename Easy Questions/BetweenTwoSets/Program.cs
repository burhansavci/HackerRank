using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoSets
{
    class Program
    {
        class Result
        {
            public static int getTotalX(List<int> a, List<int> b)
            {
                var orderedListOfa = a.OrderBy(x => x).ToList();
                var orderedListOfb = b.OrderBy(x => x).ToList();
                var factorsOfB = new List<int>();
                int factorsOfBCounter = 0;
                for (int i = orderedListOfa[orderedListOfa.Count - 1]; i <= orderedListOfb[0]; i++)
                {
                    var checkedItemCounter = 0;
                    foreach (var item in orderedListOfa)
                    {
                        if (i % item == 0)
                        {
                            checkedItemCounter++;
                        }
                        if (checkedItemCounter == orderedListOfa.Count)
                        {
                            factorsOfB.Add(i);
                        }
                    }
                }
                foreach (var item in factorsOfB)
                {
                    var checkedItemCounter = 0;
                    foreach (var item2 in orderedListOfb)
                    {
                        if (item2 % item == 0)
                        {
                            checkedItemCounter++;
                        }
                        if (checkedItemCounter == orderedListOfb.Count)
                        {
                            factorsOfBCounter++;
                        }
                    }
                }
                return factorsOfBCounter;
            }

        }
        public static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.getTotalX(arr, brr);

            Console.WriteLine(total);
            Console.ReadKey();
        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    string[] tokens_n = Console.ReadLine().Split(' ');
        //    int n = Convert.ToInt32(tokens_n[0]);
        //    int m = Convert.ToInt32(tokens_n[1]);
        //    string[] a_temp = Console.ReadLine().Split(' ');
        //    int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        //    string[] b_temp = Console.ReadLine().Split(' ');
        //    int[] b = Array.ConvertAll(b_temp, Int32.Parse);
        //    int min = a[0];
        //    int max = b[b.Length - 1];
        //    int count = 0;
        //    for (int i = min; i <= max; i++)
        //    {
        //        if (a.All(t => i % t == 0) && b.All(t => t % i == 0))
        //            count++;
        //    }
        //    Console.WriteLine(count);
        //}
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    string[] tokens_n = Console.ReadLine().Split(' ');
        //    int n = Convert.ToInt32(tokens_n[0]);
        //    int m = Convert.ToInt32(tokens_n[1]);
        //    string[] a_temp = Console.ReadLine().Split(' ');
        //    int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        //    string[] b_temp = Console.ReadLine().Split(' ');
        //    int[] b = Array.ConvertAll(b_temp, Int32.Parse);
        //    int count = 0;
        //    bool pass;

        //    Array.Sort(a);
        //    Array.Sort(b);

        //    for (int x = a[n - 1]; x <= b[0]; x++)
        //    {
        //        pass = true;

        //        for (int i = 0; i < n; i++)
        //            if (x % a[i] != 0)
        //                pass = false;

        //        for (int i = 0; i < m; i++)
        //            if (b[i] % x != 0)
        //                pass = false;

        //        if (pass)
        //            count++;
        //    }

        //    Console.WriteLine(count.ToString());
        //}
        #endregion
    }
}
