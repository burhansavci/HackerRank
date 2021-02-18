using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static BigInteger extraLongFactorials(int n)
        {
            if (n==0||n==1)          
                return 1;
            
            return extraLongFactorials(n - 1) * n;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(extraLongFactorials(n));
        }
    }
}
