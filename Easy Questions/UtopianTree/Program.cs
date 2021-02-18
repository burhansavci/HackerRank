using System;

namespace UtopianTree
{
    class Program
    {
        static int utopianTree(int n)
        {
            int heightOfTree = 1;

            if (n == 0)
                return heightOfTree;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    heightOfTree++;
                else
                    heightOfTree *= 2;
            }
            return heightOfTree;
        }

        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());
            int[] result = new int[t];
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                result[tItr] = utopianTree(n);
            }
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);
        }
    }
}
