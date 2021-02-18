using System;
using System.Collections.Generic;

namespace TheTimeInWords
{
    class Program
    {

        static string timeInWords(int h, int m)
        {
            Dictionary<int, string> hours = new Dictionary<int, string>
            {
                {1,"one"},
                {2,"two"},
                {3,"three"},
                {4,"four"},
                {5,"five"},
                {6,"six"},
                {7,"seven"},
                {8,"eight"},
                {9,"nine"},
                {10,"ten"},
                {11,"eleven"},
                {12,"twelve"},
            };
            Dictionary<int, string> minutes = new Dictionary<int, string>
            {
                {1,"one"},
                {2,"two"},
                {3,"three"},
                {4,"four"},
                {5,"five"},
                {6,"six"},
                {7,"seven"},
                {8,"eight"},
                {9,"nine"},
                {10,"ten"},
                {11,"eleven"},
                {12,"twelve"},
                {13,"thirteen"},
                {14,"fourteen"},
                {15,"quarter"},
                {16,"sixteen"},
                {17,"seventeen"},
                {18,"eighteen"},
                {19,"nineteen"},
                {20,"twelve"},
                {21,"twenty one"},
                {22,"twenty two"},
                {23,"twenty three"},
                {24,"twenty four"},
                {25,"twenty five"},
                {26,"twenty six"},
                {27,"twenty seven"},
                {28,"twenty eight"},
                {29,"twenty nine"},
                {30,"half past"},
            };
            if (m > 30)
            {
                if (h + 1 == 13)
                {
                    if (m == 45)
                    {
                        return $"{minutes[60 - m]} to {hours[h - 11]}";
                    }
                    else
                    {
                        return $"{minutes[60 - m]} minutes to {hours[h - 11]}";
                    }

                }
                else
                {
                    if (m == 45)
                    {
                        return $"{minutes[60 - m]} to {hours[h + 1]}";
                    }
                    else
                    {
                        return $"{minutes[60 - m]} minutes to {hours[h + 1]}";
                    }

                }

            }
            else if (m == 30)
            {
                return $"{minutes[m]} {hours[h]}";
            }
            else if (m == 0)
            {
                return $"{hours[h]} o' clock";
            }
            else
            {
                if (m == 15)
                {
                    return $"{minutes[m]} past {hours[h]}";
                }
                else if (m==1)
                {
                    return $"{minutes[m]} minute past {hours[h]}";
                }
                else
                {
                    return $"{minutes[m]} minutes past {hours[h]}";
                }

            }
        }

        static void Main(string[] args)
        {

            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            string result = timeInWords(h, m);

            Console.WriteLine(result);
            Console.ReadKey();

        }
        #region Other Solutions1
        //static void Main(String[] args)
        //{
        //    int h = Convert.ToInt32(Console.ReadLine());
        //    int m = Convert.ToInt32(Console.ReadLine());
        //    int n = (h == 12 ? 1 : h + 1);

        //    string[] num = {
        //                "zero","one","two","three","four","five","six","seven","eight","nine",
        //                "ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen",
        //                "twenty","twenty one","twenty two","twenty three","twenty four","twenty five","twenty six","twenty seven","twenty eight","twenty nine"
        //               };
        //    if (m == 0)
        //        Console.WriteLine(num[h] + " o'clock");
        //    else if (m == 30)
        //        Console.WriteLine("half past " + num[h]);
        //    else if (m == 15)
        //        Console.WriteLine("quarter past " + num[h]);
        //    else if (m == 45)
        //        Console.WriteLine("quarter to " + num[n]);
        //    else if (m < 30)
        //        Console.WriteLine(num[m] + " minute" + (m > 1 ? "s" : "") + " past " + num[h]);
        //    else if (m > 30)
        //        Console.WriteLine(num[60 - m] + " minute" + (60 - m > 1 ? "s" : "") + " to " + num[n]);
        //}
        #endregion
    }
}
