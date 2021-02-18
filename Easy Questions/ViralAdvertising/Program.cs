using System;

namespace ViralAdvertising
{
    class Program
    {
        static int viralAdvertising(int n)
        {
            int d = 5;
            int l = 0;
            for (int i = 0; i < n; i++)
            {
                l += (d / 2);
                d = (d / 2) * 3;
            }
            return l;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);

            Console.WriteLine(result);
        }
    }
}
