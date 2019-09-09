using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToString(n, 2).Split('0');
            Console.WriteLine(b.Max().Length);
        }

        #region Solution1
        //static void Main(String[] args)
        //{
        //int n = Convert.ToInt32(Console.ReadLine());
        //Byte[] bytes = Encoding.UTF8.GetBytes(Convert.ToString(n, 2));
        //int maxOnes = 0;
        //int currOnes = 0;
        //for (int i = 0; i < bytes.Length; ++i)
        //{
        //    if (bytes[i] == '1')
        //    {
        //        currOnes++;
        //        if (currOnes > maxOnes) maxOnes = currOnes;
        //    }
        //    else
        //    {
        //        currOnes = 0;
        //    }
        //}
        //Console.WriteLine(maxOnes);
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    String binaryNumber = "";
        //    int currentOneCount = 0;
        //    int recordOneCount = 01;

        //    while (n > 0)
        //    {
        //        int bit = n % 2;
        //        binaryNumber = bit.ToString() + binaryNumber;
        //        n = n / 2;

        //        if (bit == 1)
        //        {
        //            currentOneCount++;
        //        }
        //        else
        //        {
        //            currentOneCount = 0;
        //        }

        //        if (currentOneCount > recordOneCount)
        //        {
        //            recordOneCount = currentOneCount;
        //        }
        //    }

        //    Console.WriteLine(binaryNumber);
        //}
        #endregion
    }
}
