using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26_Nested_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dateActual = Console.ReadLine().Split(' ');
            string[] dateExpected = Console.ReadLine().Split(' ');

            int dayActual = Convert.ToInt32(dateActual[0]);
            int monthActual = Convert.ToInt32(dateActual[1]);
            int yearActual = Convert.ToInt32(dateActual[2]);

            int dayExpected = Convert.ToInt32(dateExpected[0]);
            int monthExpected = Convert.ToInt32(dateExpected[1]);
            int yearExpected = Convert.ToInt32(dateExpected[2]);

            if (yearActual > yearExpected)
                Console.WriteLine(10000);
            else if (monthActual > monthExpected && yearActual == yearExpected)
                Console.WriteLine((monthActual - monthExpected) * 500);
            else if (dayActual > dayExpected && monthActual == monthExpected && yearActual == yearExpected)
                Console.WriteLine((dayActual - dayExpected) * 15);
            else
                Console.WriteLine(0);
        }
    }
}
