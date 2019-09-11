using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Max_Sum
{
    class Program
    {
        static void miniMaxSum(long[] arr)
        {
            var orderedArr=arr.OrderBy(x=>x).ToArray();
            for (int i = 0; i < 2; i++)
            {
                var number = orderedArr.Skip(i).Take(orderedArr.Length - 1).Sum();
        
                Console.Write(number + " ");
            }

        }

        static void Main(string[] args)
        {
          
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            
            miniMaxSum(arr);
            Console.ReadKey();
            #region OtherSolutions
            #region 1
            //long[] array = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            //long sum = array.Sum();
            //long min = array.Min();
            //long max = array.Max();
            //Console.WriteLine($"{sum - max} {sum - min}");
            #endregion
            #region 2
            //var array = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            //var min = array[0];
            //var max = array[0];
            //var allSum = array[0];
            //for (var i = 1; i < array.Length; i++)
            //{
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }

            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }

            //    allSum += array[i];
            //}

            //Console.WriteLine((allSum - max) + " " + (allSum - min));
            #endregion
            #region 3
            //var numberList = Console.ReadLine().Split(' ');

            //var numbers = Array.ConvertAll(numberList, long.Parse).ToList();

            //numbers.Sort();

            //long max = 0;
            //numbers.Skip(1).Sum((x) => max += x);

            //numbers.Reverse();
            //long min = 0;
            //numbers.Skip(1).Sum((x) => min += x);

            //Console.WriteLine(min + " " + max);
            #endregion
            #endregion
        }
    }
}
