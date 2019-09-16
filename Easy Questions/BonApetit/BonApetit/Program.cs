using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonApetit
{
    class Program
    {
        static void bonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            Console.WriteLine((bill.Sum() / 2) == b ? "Bon Appetit" : (b - (bill.Sum() / 2)).ToString());
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
            Console.ReadKey();
        }
    }
}
