using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class Program
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            Console.Clear();
            var feltDownApples = new List<int>();
            for (int i = 0; i < apples.Length; i++)
            {
                var feldownApple = apples[i] + a;
                if (s <= feldownApple && feldownApple <= t)
                    feltDownApples.Add(feldownApple);
            }
            var feltDownOranges = new List<int>();
            for (int i = 0; i < oranges.Length; i++)
            {
                var feltDownOrange = oranges[i] + b;
                if (s <= feltDownOrange && feltDownOrange <= t)
                    feltDownOranges.Add(feltDownOrange);
            }
            Console.WriteLine(feltDownApples.Count);
            Console.WriteLine(feltDownOranges.Count);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the start and the end point of Sam's House");
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);
            Console.WriteLine("Please enter location of apple and orange tree ");
            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);
            Console.WriteLine("Please enter the numbers of apples and oranges");
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);
            Console.WriteLine("Please enter distances of apples");
            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;
            Console.WriteLine("Please enter distances of oranges");
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}


