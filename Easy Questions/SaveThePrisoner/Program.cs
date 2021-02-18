using System;

namespace SaveThePrisoner
{
    class Program
    {
        static int saveThePrisoner(int n, int m, int s)
        {
            if ((m + s - 1) % n == 0)
            {
                return n;
            }
            else
            {
                return (m + s - 1) % n;
            }

        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nms = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nms[0]);

                int m = Convert.ToInt32(nms[1]);

                int s = Convert.ToInt32(nms[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine(result);

            }
            Console.ReadKey();
        }
    }
}
