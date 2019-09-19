using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    class Program
    {
        static string dayOfProgrammer(int year)
        {
            if (year == 1918)
                return "26.09.1918";
            if (year > 1918)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    return "12.09." + year;
                }
                else
                {
                    return "13.09." + year;
                }
            }
            else
            {
                return year % 4 == 0 ? "12.09." + year : "13.09." + year;
            }
        }

        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfProgrammer(year);

            Console.WriteLine(result);
            Console.ReadKey();
        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    int year = Convert.ToInt32(Console.ReadLine());
        //    int[] months = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        //    if (year < 1918)
        //    {
        //        if (year % 4 == 0) months[1] = 29;
        //    }
        //    else if (year > 1918)
        //    {
        //        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) months[1] = 29;
        //    }
        //    else
        //    {
        //        months[1] = 15;
        //    }
        //    int sum = 0;
        //    int i = 0;
        //    while (true)
        //    {
        //        sum += months[i];
        //        if (256 <= sum)
        //        {
        //            sum -= months[i];
        //            break;
        //        }
        //        i++;
        //    }
        //    Console.WriteLine(new DateTime(year, i + 1, 256 - sum).ToString("dd.MM.yyyy"));
        //    Console.ReadLine();
        //}
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    int y = Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for (int i = 1; i <= 12; i++)
        //    {
        //        int num = getdays(i, y);
        //        if (sum + num <= 256)
        //        {
        //            sum += num;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{(256 - sum):00}.{i:00}.{y}");
        //            break;
        //        }
        //    }
        //}

        //static int getdays(int month, int year)
        //{
        //    if (month == 2)
        //    {
        //        int days = 0;
        //        if (isLeap(year)) days = 29;
        //        else days = 28;
        //        if (year == 1918) days -= 13;
        //        return days;

        //    }
        //    else if (month == 4 || month == 6 || month == 9 || month == 11) return 30;
        //    return 31;
        //}

        //static bool isLeap(int y)
        //{
        //    if (y < 1918) return ((y % 4) == 0);
        //    else return (((y % 400) == 0) || ((y % 4) == 0 && (y % 100) != 0));
        //}
        #endregion

    }
}
