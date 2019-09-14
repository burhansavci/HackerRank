using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumpingCounter = 0;
            for (int i = 0; i < c.Length;)
            {
                if (i + 2 <= c.Length - 1)
                {
                    if (c[i + 2] == 0)
                    {
                        jumpingCounter++;
                        i += 2;
                        continue;
                    }
                }
                if (i + 1 <= c.Length - 1)
                {
                    if (c[i + 1] == 0)
                    {
                        jumpingCounter++;
                        i++;
                        continue;
                    }
                }
                else
                    break;
            }
            return jumpingCounter;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        #region Solution1
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] c_temp = Console.ReadLine().Split(' ');
        //    int[] c = Array.ConvertAll(c_temp, Int32.Parse);

        //    int count = 0;
        //    int index = 0;
        //    while (index < n - 1)
        //    {
        //        if (index + 2 <= n - 1 && c[index + 2] != 1)
        //        {
        //            index = index + 2;
        //        }
        //        else
        //        {
        //            index = index + 1;
        //        }
        //        count++;
        //    }

        //    Console.WriteLine(count);
        //}
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] c_temp = Console.ReadLine().Split(' ');
        //    int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        //    Console.WriteLine(CloudJumps(n, c));
        //}
        //static int CloudJumps(int numberOfClouds, int[] cloudArray)
        //{
        //    int numberOfJumps = 0;

        //    for (int i = 0; i < cloudArray.Length - 1; i++)
        //    {
        //        if (i + 2 < cloudArray.Length && cloudArray[i + 2] != 1)
        //        {
        //            i++;
        //        }
        //        numberOfJumps++;
        //    }

        //    return numberOfJumps;
        //}
        #endregion


    }
}
