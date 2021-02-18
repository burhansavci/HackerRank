using System;
using System.Collections.Generic;
using System.Linq;

namespace BeautifulTriplets
{
    class Program
    {
        static int beautifulTriplets(int d, int[] arr)
        {
            int beautifulTripletCounter = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr.Contains(arr[i] + d) && arr.Contains(arr[i] + 2 * d))
                    beautifulTripletCounter++;

            return beautifulTripletCounter;
        }

        static void Main(string[] args)
        {

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = beautifulTriplets(d, arr);

            Console.WriteLine(result);
        }
    }

}
