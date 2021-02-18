using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int scoreOfAlice = 0;
            int scoreOfBob = 0;
            var totalScore = new List<int> {};
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    scoreOfAlice++;
                }
                else if (a[i] < b[i])
                {
                    scoreOfBob++;
                }
            }
            totalScore.Add(scoreOfAlice);
            totalScore.Add(scoreOfBob);
            return totalScore;

        }

        static void Main(string[] args)
        {
            var aliceScores = new List<int> { 23, 35, 45 };
            var bobScores = new List<int> { 35, 12, 88 };
            var scores=compareTriplets(aliceScores, bobScores);

            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
