using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_IntroToConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && 2 <= N && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N % 2 == 0 && 6 <= N && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
            Console.ReadKey();
        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    int N = Convert.ToInt32(Console.ReadLine());

        //    if (N % 2 == 0)
        //    {
        //        if (N <= 5)
        //        {
        //            Console.Write("Not Weird");
        //        }
        //        else if ((6 <= N) && (N <= 20))
        //        {
        //            Console.Write("Weird");
        //        }
        //        else
        //        {
        //            Console.Write("Not Weird");
        //        }
        //    }
        //    else
        //    {
        //        Console.Write("Weird");
        //    }
        //}
        #endregion
    }
}
