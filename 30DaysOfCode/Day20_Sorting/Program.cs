using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_Sorting
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int totalSwamps = 0;
            for (int j = 0; j < n; j++)
            {
                int numSwamps = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        numSwamps++;
                    }
                }
                if (numSwamps == 0)
                    break;
                else
                    totalSwamps += numSwamps;
            }

            Console.WriteLine("Array is sorted in " + totalSwamps + " swaps.");
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine($"Last Element: {a[a.Length - 1]}");
        }


    }
}
