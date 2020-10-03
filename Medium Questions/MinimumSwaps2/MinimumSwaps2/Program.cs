using System;

namespace MinimumSwaps2
{
    class Program
    {
        static int MinimumSwaps(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    var temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                    i--;
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int res = MinimumSwaps(arr);

            Console.WriteLine(res);
        }
    }
}
