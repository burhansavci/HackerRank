using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static int countingValleys(int n, string s)
        {
            int navigator = 0;
            int valleyCounter = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                    navigator++;
                else if (s[i] == 'D')
                    navigator--;
                if (navigator == 0 && s[i] == 'U')
                    valleyCounter++;
            }
            return valleyCounter;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    int charCount = Convert.ToInt32(Console.ReadLine());
        //    string steps = Console.ReadLine();

        //    int height = 0;
        //    int valleyCount = 0;
        //    for (int i = 0; i < charCount; ++i)
        //    {
        //        if (steps[i] == 'U')
        //        {
        //            ++height;
        //            if (height == 0)
        //            {
        //                ++valleyCount;
        //            }
        //        }
        //        else if (steps[i] == 'D')
        //        {
        //            --height;
        //        }
        //    }

        //    Console.WriteLine(valleyCount);
        //}
        #endregion
    }
}
