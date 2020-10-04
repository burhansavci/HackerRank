using System;
using System.Collections.Generic;

namespace TwoStrings
{
    class Program
    {
        static string TwoStrings(string s1, string s2)
        {
            var s1Subs = new HashSet<string>();
            var s2Subs = new HashSet<string>();

            for (int i = 0; i < s1.Length; i++)
            {
                s1Subs.Add(s1.Substring(i, 1));
            }

            for (int i = 0; i < s2.Length; i++)
            {
                s2Subs.Add(s2.Substring(i, 1));
            }
           
            return s1Subs.Overlaps(s2Subs) ? "YES" : "NO";
        }

        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());

            for (int pItr = 0; pItr < p; pItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = TwoStrings(s1, s2);

                Console.WriteLine(result);
            }
        }
    }
}
