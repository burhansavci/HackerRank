using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAverageRatingOfTopEmployees
{
    class Program
    {
        static void averageOfTopEmployees(int[] rating)
        {
            var topEmployees = new List<int>();
            for (int i = 0; i < rating.Length; i++)
            {
                if (rating[i] >= 90) topEmployees.Add(rating[i]);
            }
            var doublenumber = Convert.ToDouble(topEmployees.Count);
            var result = (topEmployees.Sum() / doublenumber);
            var d = Math.Round(result, 3);
            Console.WriteLine(d.ToString("F"));
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] rating = new int[n];

            for (int ratingItr = 0; ratingItr < n; ratingItr++)
            {
                int ratingItem = Convert.ToInt32(Console.ReadLine());
                rating[ratingItr] = ratingItem;
            }

            averageOfTopEmployees(rating);
            Console.ReadKey();
        }
        #region Solution1
        //static void averageOfTopEmployees(int[] rating)
        //{
        //    var selection = rating.Where(x => x >= 90).ToList();
        //    Console.WriteLine($"{selection.Average():0.00}");
        //}

        #endregion
    }
}
