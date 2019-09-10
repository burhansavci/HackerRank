using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long sumOfElementsOFArray = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sumOfElementsOFArray += ar[i];
            }
            return sumOfElementsOFArray;
        }
        static void Main(string[] args)
        {
            long[] array = { Convert.ToInt64(Math.Pow(10, 10)), Convert.ToInt64(Math.Pow(10, 10)) - 1};
            Console.WriteLine(aVeryBigSum(array)); 
            Console.ReadKey();
        }
    }
}
