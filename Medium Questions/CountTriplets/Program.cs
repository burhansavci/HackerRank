using System;
using System.Collections.Generic;
using System.Linq;

namespace CountTriplets
{
    class Program
    {
        private static long countTriplets(List<long> arr, long r)
        {
            long count = 0;
            var leftDict = new Dictionary<long, long>();
            var rightDict = new Dictionary<long, long>();

            //Fill the frequency of unique numbers to the rightDict
            foreach (var i in arr)
            {
                if (rightDict.ContainsKey(i))
                    rightDict[i]++;
                else
                    rightDict.Add(i, 1);
            }

            // currNum/r < currNum < currNum*r
            foreach (var currNum in arr)
            {
                long leftMultiplier = 0, rightMultiplier = 0;

                rightDict[currNum]--;

                if (leftDict.ContainsKey(currNum / r) && currNum % r == 0)
                    leftMultiplier = leftDict[currNum / r];
                
                if (rightDict.ContainsKey(currNum * r))
                    rightMultiplier = rightDict[currNum * r];

                count += leftMultiplier * rightMultiplier;

                if (leftDict.ContainsKey(currNum))
                    leftDict[currNum]++;
                else
                    leftDict.Add(currNum, 1);
            }

            return count;
        }

        static void Main(string[] args)
        {
            var nr = Console.ReadLine().TrimEnd().Split(' ');

            var n = Convert.ToInt32(nr[0]);

            var r = Convert.ToInt64(nr[1]);

            var arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

            var ans = countTriplets(arr, r);

            Console.WriteLine(ans);
        }
    }
}