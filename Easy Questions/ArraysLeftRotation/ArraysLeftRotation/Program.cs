using System;

namespace ArraysLeftRotation
{
    class Program
    {

        static int[] rotLeft(int[] a, int d)
        {
            var newArr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                var newLocation = (i + (a.Length - d)) % a.Length;
                newArr[newLocation] = a[i];
            }
            return newArr;
        }

        static void Main(string[] args)
        {

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
