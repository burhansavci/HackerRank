using System;

namespace HackerRankInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = Convert.ToInt32(Console.ReadLine().Trim());

            for (var qItr = 0; qItr < q; qItr++)
            {
                var s = Console.ReadLine();

                var result = hackerrankInString(s);

                Console.WriteLine(result);
            }
        }

        private static string hackerrankInString(string s)
        {
            const string hackerrank = "hackerrank";
            var j = 0;
            foreach (var ch in s)
                if (j < hackerrank.Length && ch == hackerrank[j])
                    j++;

            return hackerrank.Length == j ? "YES" : "NO";
        }
    }
}