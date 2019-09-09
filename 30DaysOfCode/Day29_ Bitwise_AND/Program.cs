using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29__Bitwise_AND
{
    class Program
    {
        static int BitwiseAND(int n, int k)
        {
            int maxValue = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    int temp = i & j;
                    if (temp > maxValue && temp < k)
                        maxValue = temp;
                    if (maxValue == k - 1)
                        return maxValue;
                }
            }
            return maxValue;

        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[t, 2];
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                arr[tItr, 0] = Convert.ToInt32(nk[0]);
                arr[tItr, 1] = Convert.ToInt32(nk[1]);

            }
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                Console.WriteLine(BitwiseAND(arr[i, 0], arr[i, 1]));
            Console.ReadKey();
        }
    }
}
