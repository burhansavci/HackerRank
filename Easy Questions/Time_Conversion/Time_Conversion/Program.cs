using System;
namespace Time_Conversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            var arr = s.Split(':');

            if (arr[arr.Length - 1].Contains("P"))
            {
                var tempTime = arr[arr.Length - 1].Trim('P', 'M');
                arr[arr.Length - 1] = tempTime;
                if (arr[0] == "12")
                {
                    return string.Join(":", arr);
                }
                else
                {
                    var militaryTime = Convert.ToInt32(arr[0]) + 12;
                    arr[0] = militaryTime.ToString();
                }

            }
            if (arr[arr.Length - 1].Contains("A"))
            {
                var tempTime = arr[arr.Length - 1].Trim('A', 'M');
                arr[arr.Length - 1] = tempTime;
                if (arr[0] == "12")
                {
                    arr[0] = "00";
                }
                else
                {
                    return string.Join(":", arr);
                }
            }

            return string.Join(":", arr);
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);

            Console.ReadKey();
            #region Other Solutions
            #region 1
            //var hour = Console.ReadLine();
            //if (hour.EndsWith("AM"))
            //{
            //    var time = hour.Split(':');
            //    var hr = Convert.ToInt32(time[0]);

            //    if (hr == 12)
            //    {
            //        hr -= 12;
            //    }

            //    Console.WriteLine("{0}:{1}:{2}", hr.ToString("00"), time[1], time[2].Replace("AM", string.Empty));
            //}
            //else
            //{
            //    var time = hour.Split(':');
            //    var hr = Convert.ToInt32(time[0]);

            //    if (hr != 12)
            //    {
            //        hr += 12;
            //    }
            //    Console.WriteLine("{0}:{1}:{2}", hr.ToString("00"), time[1], time[2].Replace("PM", string.Empty));
            //}
            #endregion
            #region 2
            //string inputTime = Console.ReadLine();
            //// check the last few characters 
            //int hour = Convert.ToInt32(inputTime.Substring(0, 2));

            //if (inputTime[8] == 'A')
            //{
            //    if (hour == 12)
            //    {
            //        hour = 0;
            //    }
            //    Console.WriteLine(string.Format("{0:00}", hour) + inputTime.Substring(2, 6));
            //}
            //else
            //{
            //    if (hour == 12)
            //    {
            //        hour = 12;
            //    }
            //    else
            //    {
            //        hour += 12;
            //    }
            //    Console.WriteLine(string.Format("{0:00}", hour) + inputTime.Substring(2, 6));
            //}
            #endregion
            #region 3
            //DateTime input = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine(input.ToString("HH:mm:ss"));
            //Console.ReadLine();
            #endregion
            #endregion

        }
    }
}
