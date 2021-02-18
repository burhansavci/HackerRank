using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    class Program
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var moneySpentList = new List<int>();
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] <= b)
                        moneySpentList.Add(keyboards[i] + drives[j]);
                }
            }
            if (moneySpentList.Count == 0)
                return -1;
            else
                return moneySpentList.Max();

        }

        static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);

        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    string[] tokens_s = Console.ReadLine().Split(' ');
        //    int s = Convert.ToInt32(tokens_s[0]);
        //    int n = Convert.ToInt32(tokens_s[1]);
        //    int m = Convert.ToInt32(tokens_s[2]);
        //    string[] keyboards_temp = Console.ReadLine().Split(' ');
        //    int[] k = Array.ConvertAll(keyboards_temp, Int32.Parse);
        //    string[] pendrives_temp = Console.ReadLine().Split(' ');
        //    int[] p = Array.ConvertAll(pendrives_temp, Int32.Parse);
        //    int sum = 0;
        //    int max = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            sum = k[i] + p[j];
        //            if (sum <= s && sum > max)
        //                max = sum;
        //        }
        //    }
        //    if (max == 0)
        //        Console.WriteLine("-1");
        //    else
        //        Console.WriteLine(max);
        //}
        #endregion
        #region Solution2

        #endregion
    }
}
