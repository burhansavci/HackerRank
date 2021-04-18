using System;
using System.Collections.Generic;

namespace IceCreamParlor
{
    class Program
    {
        static void whatFlavors(int[] cost, int money)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < cost.Length; i++)
            {
                var complement = money - cost[i];

                if (dict.ContainsKey(complement))
                {
                    // Console.WriteLine($"{Math.Min(dict[complement], i + 1)} {Math.Max(dict[complement], i + 1)}");
                    Console.WriteLine($"{dict[complement]} {i + 1}");
                    break;
                }

                dict.Add(cost[i], i + 1);
            }
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int money = Convert.ToInt32(Console.ReadLine());

                int n = Convert.ToInt32(Console.ReadLine());

                int[] cost = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

                whatFlavors(cost, money);
            }
        }
    }
}