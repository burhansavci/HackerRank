using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cakes
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            var counter = 1;
            var orderedArr = ar.OrderByDescending(x => x).ToArray();
            for (int i = 1; i < orderedArr.Length; i++)
            {
                if (orderedArr[i] != orderedArr[i -1])
                {
                    break;
                }
                counter++;
            }
            return counter;
        }

        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            
            int result = birthdayCakeCandles(ar);
            Console.WriteLine(result);
            Console.ReadKey();

            #region OtherSolutions
            #region 1
            //var heights = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //var max = heights.Max();
            //var count = heights.Count(it => it == max);
            //Console.WriteLine(count);
            #endregion
            #region 2
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //int valueMax = 0;
            //int value = 0;

            //valueMax = arr[0];
            //for (int k = 0; k < arr.Length; k++)
            //{
            //    if (arr[k] > valueMax)
            //    {
            //        valueMax = arr[k];
            //        value = 1;
            //    }
            //    else if (arr[k] == valueMax)
            //    {
            //        value++;
            //    }
            //}
            //Console.WriteLine(value.ToString());
            #endregion
            #region 3
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //List<Int32> l1 = Array.ConvertAll(arr_temp, Int32.Parse).ToList<Int32>();
            //int successCount = 0;
            //int tallestCandle = l1.Max();
            //for (int i = 0; i < n; i++)
            //{
            //    if (tallestCandle == l1[i])
            //        successCount++;
            //}
            //Console.WriteLine(successCount);
            #endregion
            #endregion

        }
    }
}
