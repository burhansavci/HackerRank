using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            var currentLocation1 = x1 + v1;
            var currentLocation2 = x2 + v2;
            for (; ; )
            {
                if (currentLocation1==currentLocation2)
                {
                    return "YES";
                }
                currentLocation1 += v1;
                currentLocation2 += v2;
                if (currentLocation1>currentLocation2)
                {
                    break;
                }
            }
            return "NO";
        }

        static void Main(string[] args)
        {

            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
            Console.ReadKey();
        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    string[] tokens_x1 = Console.ReadLine().Split(' ');
        //    int x1 = Convert.ToInt32(tokens_x1[0]);
        //    int v1 = Convert.ToInt32(tokens_x1[1]);
        //    int x2 = Convert.ToInt32(tokens_x1[2]);
        //    int v2 = Convert.ToInt32(tokens_x1[3]);


        //    if (v1 <= v2)
        //    {
        //        Console.WriteLine("NO");
        //    }
        //    else
        //    {
        //        if (((x2 - x1) % (v1 - v2)) == 0)
        //            Console.WriteLine("YES");
        //        else
        //            Console.WriteLine("NO");
        //    }

        //}
        #endregion
    }
}
