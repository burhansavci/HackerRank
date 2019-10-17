using System;

namespace FindDigits
{
    class Program
    {
        static int findDigits(int n)
        {
            int counter = 0;
            string m = n.ToString();
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i].ToString()=="0")
                    continue;
                if (n % Convert.ToInt32(m[i].ToString()) == 0)
                    counter++;
            }
            return counter;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
        }

        #region Other Solutions1
        //static void Main(string[] args)
        //{
        //    int t = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < t; i++)
        //    {
        //        string input = Console.ReadLine().Trim();
        //        long m = int.Parse(input);
        //        int ans = input.ToCharArray().Select(c => long.Parse(c.ToString())).Where(d => d > 0).Count(digit => m % digit == 0);
        //        Console.WriteLine(ans);
        //    }

        //}
        #endregion
        #region Other Solutions2
        //static void Main(string[] args)
        //{
        //    int lines = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < lines; i++)
        //    {
        //        int count = 0;
        //        int number = Convert.ToInt32(Console.ReadLine());
        //        int temp = number;
        //        while (temp > 0)
        //        {
        //            int digit = temp % 10;
        //            if (digit != 0 && number % (digit) == 0)
        //                count++;
        //            temp /= 10;
        //        }
        //        Console.WriteLine(count);
        //    }
        //}
        #endregion
    }
}
