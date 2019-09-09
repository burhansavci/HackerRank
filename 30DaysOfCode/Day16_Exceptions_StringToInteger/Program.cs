using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Exceptions_StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            try
            {
                Console.WriteLine(Convert.ToInt32(S));
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
