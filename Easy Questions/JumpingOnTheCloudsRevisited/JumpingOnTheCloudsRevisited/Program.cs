using System;

namespace JumpingOnTheCloudsRevisited
{
    class Program
    {
        static int jumpingOnClouds(int[] c, int k)
        {
            int e = 100;
            int count = 0;
            for (int i = 0; i < c.Length; i = (i + k) % c.Length)
            {
                if (i == 0)
                {
                    count++;
                    if (count == 2)
                        break;
                }
     
                if (c[i] == 0)
                    e--;
                else
                    e -= 3;
            }
            return e;
        }

        static void Main(string[] args)
        {


            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c, k);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        #region OtherSolutions1
        //static void Main(String[] args)
        //{
        //    string[] tokens_n = Console.ReadLine().Split(' ');
        //    int n = Convert.ToInt32(tokens_n[0]);
        //    int k = Convert.ToInt32(tokens_n[1]);
        //    string[] c_temp = Console.ReadLine().Split(' ');
        //    int[] c = Array.ConvertAll(c_temp, Int32.Parse);

        //    int e = 100;
        //    int position = 0;
        //    do
        //    {
        //        e--;
        //        position = (position + k) % n;
        //        if (c[position] == 1)
        //        {
        //            e -= 2;
        //        }
        //    } while (position != 0);

        //    Console.Out.WriteLine("" + e);

        //}
        #endregion
        #region OtherSolutions2
        //static void Main(String[] args)
        //{
        //    string[] tokens_n = Console.ReadLine().Split(' ');
        //    int n = Convert.ToInt32(tokens_n[0]);
        //    int k = Convert.ToInt32(tokens_n[1]);
        //    string[] c_temp = Console.ReadLine().Split(' ');
        //    int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        //    int steps = n / k;
        //    int energy = 100;
        //    int pos = 0;
        //    for (int i = 0; i < steps; i++)
        //    {
        //        pos = (pos + k) % n;
        //        if (c[pos] == 0) energy--;
        //        if (c[pos] == 1) energy -= 3;
        //    }
        //    Console.WriteLine(energy);
        //}
        #endregion
    }
}
