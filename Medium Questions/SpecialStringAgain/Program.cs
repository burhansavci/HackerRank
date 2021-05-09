using System;
using System.Collections.Generic;

namespace SpecialStringAgain
{
    class Program
    {
        static long substrCount(string s)
        {
            long substrCount = 0;

            var tupleList = new List<(char character, long count)>();

            var currentChar = s[0];
            long count = 1;
            for (var i = 1; i < s.Length; i++)
                if (s[i] == currentChar)
                    count++;
                else
                {
                    tupleList.Add((currentChar, count));
                    count = 1;
                    currentChar = s[i];
                }
            
            //Dont forget to add last sequence
            tupleList.Add((currentChar, count));

            foreach (var tuple in tupleList)
                substrCount += tuple.count * (tuple.count + 1) / 2; //combinations of same characters 

            for (var i = 1; i < tupleList.Count - 1; i++)
                if (tupleList[i - 1].character == tupleList[i + 1].character && tupleList[i].count == 1)
                    substrCount += Math.Min(tupleList[i - 1].count, tupleList[i + 1].count);

            return substrCount;
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            var s = Console.ReadLine();

            var result = substrCount(s);

            Console.WriteLine(result);
        }
    }
}