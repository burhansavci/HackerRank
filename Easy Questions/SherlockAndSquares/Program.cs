using System;

namespace SherlockAndSquares
{
    class Program
    {
        static int squares(int a, int b)
        {
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % Math.Sqrt(i) == 0)
                {
                    i = Convert.ToInt32(Math.Pow(Math.Sqrt(i) + 1d, 2)) - 1;
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = squares(a, b);

                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
        #region Other Solutions1
        //O(1) complexity
        //static void Main(String[] args)
        //{

        //    int t = Convert.ToInt32(Console.ReadLine());
        //    for (int s = 0; s < t; s++)
        //    {
        //        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //        int a = arr[0];
        //        int b = arr[1];
        //        int aroot = (int)Math.Ceiling(Math.Sqrt(a));
        //        int broot = (int)Math.Floor(Math.Sqrt(b));
        //        Console.WriteLine(broot - aroot + 1);
        //    }
        //}
        #endregion
    }
}
