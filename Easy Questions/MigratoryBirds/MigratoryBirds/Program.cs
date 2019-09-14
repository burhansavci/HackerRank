using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Program
    {
        static int migratoryBirds(List<int> migratoryBirds)
        {
            var speciesOFBirds = migratoryBirds.Distinct().ToList();
            var dictionary = new Dictionary<int, int>();
            foreach (var birdType in speciesOFBirds)
            {
                var birdCounter = 0;
                foreach (var migratoryBird in migratoryBirds)
                {
                    if (migratoryBird == birdType)
                        birdCounter++;
                }
                dictionary.Add(birdType, birdCounter);
            }
            var keyList = new List<int>();
            var maxValue = dictionary.Max(x => x.Value);
            foreach (var pair in dictionary)
            {
                if (pair.Value == maxValue)
                    keyList.Add(pair.Key);
            }
            var f = keyList.OrderBy(x => x).ToList()[0];
            //var d = dictionary.FirstOrDefault(p => p.Value == dictionary.Max(x => x.Value)).Key;
            return f;
        }

        static void Main(string[] args)
        {

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] types_temp = Console.ReadLine().Split(' ');
        //    int[] types = Array.ConvertAll(types_temp, Int32.Parse);
        //    // your code goes here
        //    int[] birdCounts = new int[6];

        //    foreach (var type in types)
        //        birdCounts[type]++;

        //    int maxValue = birdCounts.Max();
        //    int maxType = birdCounts.ToList().IndexOf(maxValue);

        //    Console.WriteLine(maxType);

        //}
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] types_temp = Console.ReadLine().Split(' ');
        //    int[] types = Array.ConvertAll(types_temp, Int32.Parse);
        //    // your code goes here
        //    int[] birdCount = new int[5];
        //    types.ToList().ForEach(x => birdCount[x - 1] += 1);
        //    Console.WriteLine(birdCount.ToList().FindIndex(x => x == birdCount.Max()) + 1);
        //}
        #endregion
    }
}
