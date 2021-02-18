using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {
            int bestScoreRecord = 0;
            int bestScore;
            int worstScoreRecord = 0;
            int worstScore;
            if (scores.Length == 1)
            {
                return new int[] { bestScoreRecord, worstScoreRecord };
            }
            if (scores[1] > scores[0])
            {
                bestScoreRecord++;
                bestScore = scores[1];
                worstScore = scores[0];
            }
            else if (scores[1] == scores[0])
            {
                bestScore = scores[1];
                worstScore = scores[0];
            }
            else
            {
                worstScoreRecord++;
                bestScore = scores[0];
                worstScore = scores[1];
            }
            for (int i = 2; i < scores.Length; i++)
            {
                if (scores[i] > bestScore)
                {
                    bestScoreRecord++;
                    bestScore = scores[i];
                }
                if (scores[i] < worstScore)
                {
                    worstScoreRecord++;
                    worstScore = scores[i];
                }
            }
            return new int[] { bestScoreRecord, worstScoreRecord };
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
            Console.ReadKey();

        }

        #region Solution1
        //public static void Main()
        //{
        //    Console.ReadLine();
        //    int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //    int best = nums[0];
        //    int worst = nums[0];
        //    int bestCount = 0;
        //    int worstCount = 0;
        //    foreach (var n in nums)
        //    {
        //        if (n > best)
        //        {
        //            best = n;
        //            bestCount++;
        //        }
        //        if (n < worst)
        //        {
        //            worst = n;
        //            worstCount++;
        //        }
        //    }
        //    Console.WriteLine(bestCount + " " + worstCount);
        //}
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] score_temp = Console.ReadLine().Split(' ');
        //    int[] score = Array.ConvertAll(score_temp, Int32.Parse);
        //    int C = 0, F = 0;
        //    for (int i = 1; i < score.Length; i++)
        //    {
        //        if (score.Take(i).Min() > score[i])
        //            F++;
        //        if (score.Take(i).Max() < score[i])
        //            C++;
        //    }
        //    Console.WriteLine(C + " " + F);
        //}
        #endregion
    }
}
