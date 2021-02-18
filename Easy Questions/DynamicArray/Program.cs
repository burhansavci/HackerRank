using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    class Program
    {
        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            int lastAnswer = 0;
            List<int> lastAnswerList = new List<int>();
            var list = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                list.Add(new List<int>());
            }

            foreach (var query in queries)
            {
                if (query[0] == 1)
                {
                    var listindex = (query[1] ^ lastAnswer) % n;
                    ((List<int>)list[listindex]).Add(query[2]);
                }
                if (query[0] == 2)
                {
                    var listindex = (query[1] ^ lastAnswer) % n;
                    lastAnswer = ((List<int>)list[listindex])[query[2] % ((List<int>)list[listindex]).Count];
                    lastAnswerList.Add(lastAnswer);
                }
            }
            return lastAnswerList;
        }


        public static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = dynamicArray(n, queries);

            Console.WriteLine(String.Join("\n", result));
            Console.ReadLine();
        }
        #region OtherSolutions1
        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    string[] tmp = Console.ReadLine().Split();
        //    int n = Convert.ToInt32(tmp[0]);
        //    int q = Convert.ToInt32(tmp[1]);

        //    int[][] queries = new int[q][];

        //    for (int i = 0; i < q; i++)
        //    {
        //        tmp = Console.ReadLine().Split();

        //        queries[i] = new int[3];

        //        queries[i][0] = Convert.ToInt32(tmp[0]);
        //        queries[i][1] = Convert.ToInt32(tmp[1]);
        //        queries[i][2] = Convert.ToInt32(tmp[2]);
        //    }

        //    int lastans = 0;
        //    List<int>[] sequences = new List<int>[n];
        //    for (int i = 0; i < n; i++)
        //        sequences[i] = new List<int>();

        //    for (int i = 0; i < q; i++)
        //    {
        //        if (queries[i][0] == 1)
        //        {
        //            sequences[(queries[i][1] ^ lastans) % n].Add(queries[i][2]);
        //        }
        //        else
        //        {
        //            int seq = (queries[i][1] ^ lastans) % n;
        //            int ans = sequences[seq][queries[i][2] % sequences[seq].Count];

        //            Console.WriteLine(ans);

        //            lastans = ans;
        //        }
        //    }
        //}
        #endregion
    }
}
