using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] a)
        {
            elements = a;
        }
        public void computeDifference()
        {
            maximumDifference = elements.Max() - elements.Min();
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
