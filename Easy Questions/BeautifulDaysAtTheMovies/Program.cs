using System;
using System.Linq;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int beautifulDays = 0;

            for (int a = i; a <= j; a++)
            {
                char[] b = a.ToString().ToCharArray();
                for (int c = 0; c < b.Length / 2; c++)
                {
                    char tmp = b[c];
                    b[c] = b[b.Length - 1 - c];
                    b[b.Length - 1 - c] = tmp;
                }
                int reverseA = Convert.ToInt32(new string(b));
                if (Math.Abs(a - reverseA) % k == 0)
                    beautifulDays++;
            }
            Console.WriteLine(beautifulDays);
            Console.ReadLine();
        }

    }
}
