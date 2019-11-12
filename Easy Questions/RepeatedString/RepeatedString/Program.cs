using System;
using System.Collections.Generic;

namespace RepeatedString
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
            var list = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    list.Add(i);
                }
            }
            if (n % s.Length == 0)
            {
                return (n / s.Length) * list.Count;
            }
            else
            {
                int extra = 0;
                foreach (var item in list)
                {
                    if (item <= (n % s.Length - 1))
                    {
                        extra++;
                    }
                }
                return ((n / s.Length) * list.Count) + extra;
            }
        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
            Console.ReadKey();
        }
        #region Other Solutions1
        //class Program
        //{
        //    static void Main(String[] args)
        //    {
        //        string s = Console.ReadLine();
        //        long n = Convert.ToInt64(Console.ReadLine());

        //        var inSingle = s.Count(x => x == 'a');

        //        var full = n / s.Length;

        //        var rest = n % s.Length;

        //        var inRest = s.Substring(0, (int)rest).Count(x => x == 'a');

        //        var result = (inSingle * full) + inRest;

        //        Console.WriteLine(result);

        //    }
        //}
        #endregion
        #region Other Solutions2
        //static void Main(String[] args)
        //{
        //    string s = Console.ReadLine();
        //    long n = Convert.ToInt64(Console.ReadLine());
        //    long acount = 0;
        //    int len = s.Length;
        //    for (int i = 0; i < len; i++)
        //    {
        //        if (s[i] == 'a')
        //            acount++;
        //    }
        //    acount = acount * (n / len);
        //    long mod = n % len;
        //    //Console.WriteLine(mod);
        //    for (int i = 0; i < mod; i++)
        //    {
        //        if (s[i] == 'a')
        //            acount++;
        //    }
        //    Console.WriteLine(acount);
        //}
        #endregion
    }
}
