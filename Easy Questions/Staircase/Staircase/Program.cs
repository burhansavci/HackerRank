using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j =1; j <= n; j++)
                {
                    if ((i+j)>n)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
            Console.ReadKey();
        }
    }
}
