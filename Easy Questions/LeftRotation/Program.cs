using System;

namespace LeftRotation
{
    class Program
    {
        static int[] RotateLeft(int[] arr, int times)
        {
            int[] rotatedArr = new int[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                rotatedArr[(arr.Length - (times - i)) % arr.Length] = arr[i];
            }
            return rotatedArr;
        }

        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] rotatedArr = RotateLeft(a, d);
            for (int i = 0; i < rotatedArr.Length; i++)
            {
                Console.Write(rotatedArr[i] + " ");
            }
        }
    }

}
