using System;
using System.Text;

namespace CavityMap
{
    class Program
    {
        static string[] cavityMap(string[] grid)
        {

            for (int i = 1; i < grid.Length - 1; i++)
            {
                for (int j = 1; j < grid[i].Length - 1; j++)
                {
                    if (grid[i][j] > grid[i][j - 1] && grid[i][j] > grid[i][j + 1] && grid[i][j] > grid[i + 1][j] && grid[i][j] > grid[i - 1][j])
                    {
                        StringBuilder sb = new StringBuilder(grid[i]);
                        sb[j] = 'X';
                        grid[i] = sb.ToString();
                    }
                }
            }
            return grid;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string[] grid = new string[n];

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid[i] = gridItem;
            }

            string[] result = cavityMap(grid);

            Console.WriteLine(string.Join("\n", result));
        }
        #region Other Solutions1
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] grid = new string[n];
        //    for (int grid_i = 0; grid_i < n; grid_i++)
        //    {
        //        grid[grid_i] = Console.ReadLine();
        //    }

        //    int[][] a = new int[n][];
        //    for (int i = 0; i < n; i++)
        //        a[i] = new int[n];

        //    for (int i = 0; i < n; i++)
        //        for (int j = 0; j < n; j++)
        //            a[j][i] = Convert.ToInt32(grid[j].Substring(i, 1));

        //    for (int i = 1; i < n - 1; i++)
        //        for (int j = 1; j < n - 1; j++)
        //            if (a[i][j] > a[i][j - 1] && a[i][j] > a[i][j + 1] && a[i][j] > a[i - 1][j] && a[i][j] > a[i + 1][j])
        //            {
        //                grid[i] = grid[i].Substring(0, j) + "X" + grid[i].Substring(j + 1);
        //            }

        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.WriteLine(grid[i]);
        //    }
        //}
        #endregion

    }
}
