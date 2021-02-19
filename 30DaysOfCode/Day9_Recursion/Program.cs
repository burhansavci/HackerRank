using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Recursion3
{
    class Program
    {
        static int factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n-1);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            Console.WriteLine(result);
        }
    }
}
