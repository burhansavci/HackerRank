using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {
        static int pageCount(int n, int p)
        {
            int turnCounter = 0;
            if (p > n / 2)
            {
                if (p == n)
                    return turnCounter;
                if (n % 2 != 0 && p == n - 1)
                    return turnCounter;
                if (n % 2 == 0 && p == n - 1)
                    return ++turnCounter;
                while (p < n)
                {
                    turnCounter++;
                    n--;
                }
            }
            else
            {
                if (p == 1)
                    return turnCounter;
                for (int i = 0; i < p; i++)
                    turnCounter++;
                return turnCounter / 2;
            }
            return turnCounter / 2;
        }

        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int p = Convert.ToInt32(Console.ReadLine());
        //    int front = p / 2;
        //    int back = (n / 2) - front;
        //    Console.WriteLine(Math.Min(front, back));
        //}
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int p = Convert.ToInt32(Console.ReadLine());
        //    // your code goes here

        //    int res = n % 2 == 0 ? Math.Min(((n - p) / 2 + (n - p) % 2), ((p - 1) / 2 + (p - 1) % 2)) : Math.Min((n - p) / 2, ((p - 1) / 2 + (p - 1) % 2));

        //    Console.WriteLine(res);
        //}
        #endregion
    }
}
