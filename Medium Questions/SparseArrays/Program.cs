using System;
using System.Collections.Generic;
using System.Linq;

namespace SparseArrays
{
    class Program
    {
        static int[] MatchingStrings(string[] strings, string[] queries)
        {

            Dictionary<string, int> queryDict = new Dictionary<string, int>();
            for (int i = 0; i < queries.Length; i++)
            {
                if (!queryDict.ContainsKey(queries[i]))
                {
                    queryDict.Add(queries[i], 0);
                }
            }

            for (int i = 0; i < strings.Length; i++)
            {
                if (queryDict.ContainsKey(strings[i]))
                {
                    queryDict[strings[i]]++;
                }
            }

            int[] queryOccurences = new int[queries.Length];
            for (int i = 0; i < queryOccurences.Length; i++)
            {
                queryOccurences[i] = queryDict[queries[i]];
            }
            return queryOccurences;
        }

        static void Main(string[] args)
        {

            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            int[] res = MatchingStrings(strings, queries);

            Console.WriteLine(string.Join("\n", res));
        }
    }
}
