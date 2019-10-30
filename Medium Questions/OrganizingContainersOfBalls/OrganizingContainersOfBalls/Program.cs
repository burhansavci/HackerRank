using System;

namespace OrganizingContainersOfBalls
{
    class Program
    {
        static string organizingContainers(int[][] container)
        {
            int n = container.Length;
            var capacityArr = new int[n];
            var ballArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ballArr[j] += container[i][j];
                    capacityArr[i] += container[i][j];
                }
            }
            Array.Sort(ballArr);
            Array.Sort(capacityArr);
            for (int i = 0; i < n; i++)
            {
                if (ballArr[i] != capacityArr[i])
                {
                    return "Impossible";
                }
            }
            return "Possible";
        }

        static void Main(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[][] container = new int[n][];

                for (int i = 0; i < n; i++)
                {
                    container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
                }

                string result = organizingContainers(container);

                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
