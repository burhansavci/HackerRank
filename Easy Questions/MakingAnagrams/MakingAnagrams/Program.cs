using System;
using System.Collections.Generic;
using System.Linq;

namespace MakingAnagrams
{
    class Program
    {
        static int makeAnagram(string a, string b)
        {
            var arr = new int[26];
            foreach (var item in a)            
                arr[item - 'a']++;
            
            foreach (var item in b)           
                arr[item - 'a']--;
            
            return arr.Where(x => x != 0).Sum(x => Math.Abs(x));
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            int res = makeAnagram(a, b);

            Console.WriteLine(res);
        }

        #region OtherSolutions1
        //static void Main(String[] args)
        //{
        //    string a = Console.ReadLine();
        //    string b = Console.ReadLine();

        //    Dictionary<char, int> frequencyA = CountChars(a);
        //    Dictionary<char, int> frequencyB = CountChars(b);

        //    int removalCount = 0;

        //    foreach (var key in frequencyA.Keys)
        //    {
        //        removalCount += Math.Abs(frequencyA[key] - frequencyB[key]);
        //    }

        //    Console.WriteLine(removalCount);

        //}

        //public static Dictionary<char, int> CountChars(string input)
        //{
        //    Dictionary<char, int> letterFrequency = new Dictionary<char, int>();
        //    string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //    foreach (var c in alphabet)
        //    {
        //        letterFrequency.Add(c, 0);
        //    }

        //    foreach (var c in input)
        //    {
        //        letterFrequency[c]++;
        //    }
        //    return letterFrequency;
        //}
        #endregion
    }
}
