using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            string s = Console.ReadLine();
            int i2 = 4;
            double d2 = 4.0;
            string s2 = "HackerRank";
            Console.WriteLine(i + i2);
            Console.WriteLine($"{d + d2:0.0}"); ;
            Console.WriteLine(s2 + s);
            Console.ReadKey();
        }
        #region Solution1
        //Console.WriteLine(Convert.ToInt32(Console.ReadLine()) + i);
        //Console.WriteLine("{0:.0}", Convert.ToDouble(Console.ReadLine()) + d);
        //Console.WriteLine(s + Console.ReadLine());
        #endregion
        #region Solution2
        //// Declare second integer, double, and String variables.
        //int num;
        //double fullnum;
        //string qoutes;

        //// Read and save an integer, double, and String to your variables.
        //num = Convert.ToInt32(Console.ReadLine());
        //fullnum=Convert.ToDouble(Console.ReadLine());
        //qoutes=Console.ReadLine();

        //// Print the sum of both integer variables on a new line.
        //Console.WriteLine(num+i);
        //// Print the sum of the double variables on a new line.
        // Console.WriteLine(string.Format("{0:0.0}", fullnum+d));
        //// Concatenate and print the String variables on a new line
        //// The 's' variable above should be printed first.
        //Console.WriteLine(s+qoutes);
        #endregion
        #region Solution3
        //// Declare second integer, double, and String variables.
        //int secondInt = 0;
        //double secondDouble = 0.0;
        //string secondString = "";
        //// Read and save an integer, double, and String to your variables.
        //secondInt = int.Parse(Console.ReadLine());
        //secondDouble = double.Parse(Console.ReadLine());
        //secondString = Console.ReadLine();
        //// Print the sum of both integer variables on a new line.
        //Console.WriteLine(i + secondInt);
        //// Print the sum of the double variables on a new line.
        //Console.WriteLine((d + secondDouble).ToString("#.0"));
        //// Concatenate and print the String variables on a new line
        //// The 's' variable above should be printed first.
        //Console.WriteLine(s + secondString);
        #endregion
    }
}
