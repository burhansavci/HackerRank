using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static int diagonalDifference(int[,] arr)
        {
            int sumOfRightToLeft = 0;
            int sumOfLeftToRight = 0;
            int j = arr.GetLength(0) - 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {                
                sumOfLeftToRight += arr[i, i];
                sumOfRightToLeft += arr[i, j];
                j--;
            }

            return Math.Abs(sumOfLeftToRight-sumOfRightToLeft);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] lineSplit = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(lineSplit[j]);
                }
            }

            Console.WriteLine(diagonalDifference(array));
            Console.ReadKey();
        }
    }
}
