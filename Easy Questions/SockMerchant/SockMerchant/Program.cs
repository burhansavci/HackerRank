using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static int sockMerchant(int[] ar)
        {
            int pairOfSocks = 0;
            var typeOfSocks = ar.Distinct().ToList();
            var countOfSocks = new List<int>();
            for (int i = 0; i < typeOfSocks.Count; i++)
            {
                countOfSocks.Add(ar.Count(x => x == typeOfSocks[i]));
            }
            foreach (var countOfSock in countOfSocks)
            {
                if (countOfSock % 2 != 0)
                    pairOfSocks += (countOfSock - 1) / 2;
                else
                    pairOfSocks += countOfSock / 2;
            }
            return pairOfSocks;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(ar);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        //    Array.Sort(A);
        //    int ans = 0;
        //    for (int i = 1; i < n; i++)
        //    {
        //        if (A[i] == A[i - 1]) { ans++; i++; }
        //    }
        //    Console.WriteLine(ans);
        //}
        #endregion
    }
}
