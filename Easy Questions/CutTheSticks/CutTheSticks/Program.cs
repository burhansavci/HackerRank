using System;
using System.Collections.Generic;
using System.Linq;

namespace CutTheSticks
{
    class Program
    {
        static List<int> cutTheSticks(int[] arr)
        {
            var sticksCut = new List<int>();
            while (arr.Length > 0)
            {
                var min = arr.Min();
                sticksCut.Add(arr.Length);

                for (int i = 0; i < arr.Length; i++)
                    arr[i] -= min;

                arr = Array.FindAll(arr, x => x != 0).ToArray();
            }
            return sticksCut;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            List<int> result = cutTheSticks(arr);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadKey();
        }
        #region Other Solutions1
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] arr_temp = Console.ReadLine().Split(' ');
        //    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        //    while (arr.Length > 0)
        //    {
        //        Console.WriteLine(arr.Length);
        //        arr = arr.Where(val => val != arr.Min()).ToArray();
        //    }
        //}
        #endregion
        #region Other Solutions2
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] arr_temp = Console.ReadLine().Split(' ');
        //    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);


        //    Array.Sort(arr);
        //    Console.WriteLine(n);

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (arr[i] > arr[i - 1])
        //        { Console.WriteLine(n - i); }
        //    }
        //}
        #endregion
    }
}
