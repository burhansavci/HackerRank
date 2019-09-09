using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25_Running_Time_And_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[T];
            for (int i = 0; i < T; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                {
                    Console.WriteLine("Prime");
                    continue;
                }
                if (arr[i] % 2 == 0 || arr[i] == 1)
                    Console.WriteLine("Not prime");
                else
                {
                    bool primeCheck = true;
                    for (int j = 3; j * j <= arr[i]; j++)//j+=2; daha iyi bir çözümdür çünkü arr[i] zaten tek bir sayı olduğu için sadece tek sayılara bakmak yeterli olcaktır.
                    {
                        if (arr[i] % j == 0)
                            primeCheck = false;
                    }
                    if (primeCheck)
                        Console.WriteLine("Prime");
                    else
                        Console.WriteLine("Not prime");
                }
            }
            #region Solution1
            //static void Main(String[] args)
            //{
            //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            //    int n = Int32.Parse(Console.ReadLine());
            //    while (n-- > 0)
            //    {
            //        long aNum = Int64.Parse(Console.ReadLine());
            //        Console.WriteLine(IsPrime(aNum) ? "Prime" : "Not prime");
            //    }
            //}
            //static bool IsPrime(long n)
            //{
            //    if (n == 1) return false;
            //    if (n == 2) return true;
            //    if (n % 2 == 0) return false;

            //    for (int i = 3; i <= Math.Sqrt(n); i += 2)
            //    {
            //        if (n % i == 0) return false;
            //    }
            //    return true;
            //}
            #endregion
            #region Solution2

            #endregion
        }
    }
}
