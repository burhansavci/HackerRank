using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr, decimal positiveNumbers = 0, decimal negativeNumbers = 0, decimal zeros = 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveNumbers++;
                }
                else if (arr[i] < 0)
                {
                    negativeNumbers++;
                }
                else
                {
                    zeros++;
                }
            }
            Console.WriteLine(positiveNumbers / arr.Length);
            Console.WriteLine(negativeNumbers / arr.Length);
            Console.WriteLine(zeros / arr.Length);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
            Console.ReadKey();
        }
    }
}

