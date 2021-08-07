using System;
using System.Text;

namespace SeparateTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = Convert.ToInt32(Console.ReadLine().Trim());

            for (var qItr = 0; qItr < q; qItr++)
            {
                var s = Console.ReadLine();

                separateNumbers(s);
            }
        }


        private static void separateNumbers(string s)
        {
            var strBuilder = new StringBuilder();
            for (var subStringLength = 1; subStringLength <= s.Length / 2; subStringLength++)
            {
                strBuilder.Clear();

                var firstNumberAsStr = s.Substring(0, subStringLength);
                var firstNumber = long.Parse(firstNumberAsStr);
                strBuilder.Append(firstNumber);
                var number = firstNumber;
                for (var i = 0; i < s.Length - firstNumberAsStr.Length; i += number.ToString().Length)
                    strBuilder.Append(++number);

                if (strBuilder.ToString() == s)
                {
                    Console.WriteLine($"YES {firstNumber}");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}