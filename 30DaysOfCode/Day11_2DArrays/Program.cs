using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int max = -55;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var d =    arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                                           arr[i + 1][j + 1] +
                           arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (d > max) max = d;
                }
            }
            Console.WriteLine(max);
        }
    }
}
