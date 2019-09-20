using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    class Program
    {
        public static int pickingNumbers(List<int> a)
        {
            int maxCount = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count; j++)
                {
                    if (a[i] - a[j] <= 1 && a[i] - a[j] >= 0)
                    {
                        list.Add(a[j]);
                    }
                }
                if (list.Count > maxCount)
                {
                    maxCount = list.Count;
                }
                list.RemoveRange(0, list.Count);
            }
            return maxCount;
        }


        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);
            Console.WriteLine(result);
            Console.ReadLine();


        }

        #region OtherSolutions1
        //static void Main(string[] args)
        //{
        //    Console.ReadLine();
        //    var nums = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
        //    var maxCount = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        var curVal = nums[i];
        //        var curLowerCount = nums.Where(x => x == curVal || x == curVal - 1).Count();
        //        var curUpperCount = nums.Where(x => x == curVal || x == curVal + 1).Count();
        //        if (curLowerCount > maxCount)
        //        {
        //            maxCount = curLowerCount;
        //        }
        //        if (curUpperCount > maxCount)
        //        {
        //            maxCount = curUpperCount;
        //        }
        //    }
        //    Console.WriteLine(maxCount);
        //}
        #endregion
        #region OtherSolutions2
        //O(n) complexity
        //public static void Main(string[] args)
        //{

        //    int n = Convert.ToInt32(Console.ReadLine().Trim());
        //    int[] frequencyArr = new int[100 + 1];
        //    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        //    for (int i = 0; i < n; i++)
        //    {
        //        frequencyArr[a[i]]++;
        //    }
        //    int max = 0;
        //    for (int i = 1; i < n; i++)
        //    {
        //        int count = frequencyArr[i] + frequencyArr[i - 1];
        //        if (count > max)
        //        {
        //            max = count;
        //        }
        //    }
        //    Console.WriteLine(max);
        //    Console.ReadLine();
        //}
        #endregion
    }
}
