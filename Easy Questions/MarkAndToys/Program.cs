using System;

namespace MarkAndToys
{
    class Program
    {
        static int MaximumToys(int[] prices, int k)
        {
            Array.Sort(prices);
            var toysCount = 0;
            foreach (var price in prices)
            {
                if (k < price)
                    break;
                
                k -= price;
                toysCount++;
            }
            return toysCount;
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

            int result = MaximumToys(prices, k);

            Console.WriteLine(result);
        }
    }
}