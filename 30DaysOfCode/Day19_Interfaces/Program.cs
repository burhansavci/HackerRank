using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Interfaces
{
    class Program
    {
        interface AdvancedArithmetic
        {
            int divisorSum(int n);
        }
        public class Calculator : AdvancedArithmetic
        {
            public int divisorSum(int n)
            {
                int total = 1;
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                        total += i;
                }
                return total;
            }
        }
            static void Main(string[] args)
            {
                int n = Int32.Parse(Console.ReadLine());
                AdvancedArithmetic myCalculator = new Calculator();
                int sum = myCalculator.divisorSum(n);
                Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
            }
        #region Solution1
        //class Calculator : AdvancedArithmetic
        //{

        //    public int divisorSum(int num)
        //    {
        //        int sum = 0;
        //        if (num == 1)
        //        {
        //            return 1;
        //        }
        //        else
        //        {
        //            for (int i = 2; i <= num / 2; i++)
        //            {
        //                if (num % i == 0)
        //                {
        //                    sum += i;
        //                }
        //            }
        //            return sum + 1 + num;
        //        }
        //    }
        //}
        #endregion
    }
}
