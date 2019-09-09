using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] arr_temp = Console.ReadLine().Split(' ');
        //    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

        //    Array.Reverse(arr);

        //    foreach (int value in arr)
        //    {
        //        Console.Write(value);
        //        Console.Write(" ");
        //    }
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] arr_temp = Console.ReadLine().Split(' ');
        //    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        //    for (int i = 0, j = n - 1; i < j; i++, j--)
        //    {
        //        int temp = arr[i];
        //        arr[i] = arr[j];
        //        arr[j] = temp;
        //    }

        //    for (int i = 0; i < n; i++)
        //        Console.Write(arr[i] + " ");
        //}
        #endregion
    }
}
