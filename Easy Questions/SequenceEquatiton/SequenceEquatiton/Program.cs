using System;
using System.Collections;

namespace SequenceEquatiton
{
    class Program
    {
        static int[] permutationEquation(int[] p)
        {
            var table = new Hashtable();
            var yArr = new int[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                table[p[i]] = i + 1;
            }
            for (int i = 0; i < yArr.Length; i++)
            {
                yArr[i] = (int)table[table[i + 1]];
            }
            return yArr;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));

            int[] result = permutationEquation(p);

            Console.WriteLine(string.Join("\n", result));
        }

        #region OtherSolutions1

        //public static void Main(String[] args)
        //{

        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int[] p_inverse = new int[n + 1];
        //    for (int x = 1; x <= n; x++)
        //    {
        //        int px = Convert.ToInt32(Console.ReadLine());
        //        p_inverse[px] = x;
        //    }

        //    for (int x = 1; x <= n; x++)
        //    {
        //        int y = p_inverse[p_inverse[x]];
        //        Console.WriteLine(y);
        //    }
        //    Console.ReadLine();
        //}

        #endregion
    }
}
