using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {
            var selectedChocolateBarCounter = 0; 
            for (int i = 0; i < s.Count-(m-1); i++)
            {
                if (s.Skip(i).Take(m).Sum() == d)
                    selectedChocolateBarCounter++;
            }
            return selectedChocolateBarCounter;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);
            Console.ReadKey();
        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    //string[] squares_temp = Console.ReadLine().Split(' ');
        //    int[] s = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //    string[] tokens_d = Console.ReadLine().Split(' ');
        //    int d = Convert.ToInt32(tokens_d[0]);
        //    int m = Convert.ToInt32(tokens_d[1]);
        //    int sum = 0;
        //    int count = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        sum = 0;
        //        for (int j = 0; j < m && (i + j) < n; j++)
        //        {
        //            sum += s[i + j];
        //        }
        //        if (sum == d)
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(count);
        //}
        #endregion
    }
}
