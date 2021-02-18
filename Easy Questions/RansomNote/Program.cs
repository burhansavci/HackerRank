using System;
using System.Collections.Generic;

namespace RansomNote
{
    class Program
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            bool isValid = true;
            int count = -1;
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if (!dic.ContainsKey(magazine[i])) dic.Add(magazine[i], 1);
                else dic[magazine[i]]++;
            }

            for (int i = 0; i < note.Length; i++)
            {
                if (!dic.TryGetValue(note[i], out count) || count <= 0) isValid = false;
                else dic[note[i]]--;
            }
            Console.WriteLine(isValid ? "Yes" : "No");
        }

        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}
