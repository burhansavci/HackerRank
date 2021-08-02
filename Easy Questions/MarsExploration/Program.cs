using System;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            int result = marsExploration(s);

            Console.WriteLine(result);
        }

        public static int marsExploration(string s)
        {
            const string sos = "SOS";
            var count = 0;
            for (var i = 0; i < s.Length; i += 3)
            {
                if (sos[0] != s[i])
                    count++;
                if (sos[1] != s[i + 1])
                    count++;
                if (sos[2] != s[i + 2])
                    count++;
            }

            return count;
        }
    }
}