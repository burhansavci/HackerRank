using System;

namespace AlternatingCharacters
{
    class Program
    {
        static int AlternatingCharacters(string s)
        {
            var deletionCounts = 0;
            for (var i = 1; i < s.Length; i++)
                if (s[i - 1] == s[i])
                    deletionCounts++;

            return deletionCounts;
        }

        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = AlternatingCharacters(s);

                Console.WriteLine(result);
            }
        }
    }
}