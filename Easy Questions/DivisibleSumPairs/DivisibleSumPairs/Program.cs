using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int divisibleSumPairsCounter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j && (ar[i] + ar[j]) % k == 0)
                        divisibleSumPairsCounter++;
                }
            }
            return divisibleSumPairsCounter;
        }

        static void Main(string[] args)
        {

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);
            Console.ReadKey();
        }
        #region Solution1
        //static void Main(String[] args)
        //{
            //string[] tokens_n = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(tokens_n[0]);
            //int k = Convert.ToInt32(tokens_n[1]);
            //string[] a_temp = Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            //int count = 0;

            //for (int j = 0; j < n; j++)
            //    for (int i = 0; i < j; i++)
            //        if ((a[i] + a[j]) % k == 0)
            //            count++;

            //Console.WriteLine(count);
        }
        #endregion
    }
}
