using System;

namespace BeautifulBinaryString
{
    class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine().Trim());

            var b = Console.ReadLine();

            var result = beautifulBinaryString(b);

            Console.WriteLine(result);
        }

        public static int beautifulBinaryString(string b)
        {
            var beautifulBinaryString = b.Replace("010", string.Empty);
            return (b.Length - beautifulBinaryString.Length) / 3;
        }
    }
}