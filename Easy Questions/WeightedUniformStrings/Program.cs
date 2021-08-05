using System;
using System.Collections.Generic;
using System.Linq;

namespace WeightedUniformStrings
{
    class Program
    {
        public static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            var queries = new List<int>();

            for (var i = 0; i < queriesCount; i++)
            {
                var queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }

            var result = weightedUniformStrings(s, queries);

            Console.WriteLine(string.Join("\n", result));
        }
        
        private static List<string> weightedUniformStrings(string s, List<int> queries)
        {
            var weightsSet = new HashSet<int>();
            var sum = s[0] % 96;
            weightsSet.Add(sum);
            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                    sum += s[i] % 96;
                else
                    sum = s[i + 1] % 96;
                
                weightsSet.Add(sum);
            }

            return queries.Select(query => weightsSet.Contains(query) ? "Yes" : "No").ToList();
        }
    }
}