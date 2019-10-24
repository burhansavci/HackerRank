using System;
using System.Linq;

namespace Encryption
{
    class Program
    {
        static string encryption(string s)
        {
            var column = Convert.ToInt32(Math.Ceiling(Math.Sqrt(s.Length)));
            var row = Convert.ToInt32(Math.Floor(Math.Sqrt(s.Length)));
            string encryptedString = "";
            var columnCounter = 0;
            int rowCounter = 0;
            if (row * column < s.Length || row == column)
            {
                row = column;
                while (columnCounter < s.Length)
                {
                    for (int i = 0; i < row; i++)
                    {
                        encryptedString += String.Concat(s.Skip((i * column) + rowCounter).Take(1));
                    }
                    encryptedString += " ";
                    columnCounter += column;
                    rowCounter++;
                }
            }
            else
            {
                while (columnCounter < s.Length + column)
                {
                    for (int i = 0; i < row; i++)
                    {
                        encryptedString += String.Concat(s.Skip((i * column) + rowCounter).Take(1));
                    }
                    encryptedString += " ";
                    columnCounter += column;
                    rowCounter++;
                }
            }

            return encryptedString;

        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            string result = encryption(s);

            Console.WriteLine(result);
            Console.ReadKey();

        }

        #region Other Solutions1
        //static void Main(String[] args)
        //{
        //    string s = Console.ReadLine();
        //    s = s.Replace(" ", String.Empty);
        //    int len = s.Length;
        //    //Console.WriteLine(len);
        //    double root = Math.Sqrt(len);
        //    int rows = (int)Math.Floor(root);
        //    //Console.WriteLine(rows);
        //    int cols = (int)Math.Ceiling(root);
        //    //Console.WriteLine(cols);
        //    if (rows * cols < len)
        //        rows++;
        //    char[,] grid = new char[rows, cols];
        //    int index = 0;
        //    for (int i = 0; i < rows && index < len; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            grid[i, j] = s[index];
        //            index++;
        //            if (index == len)
        //                break;
        //        }
        //    }
        //    string line = String.Empty;
        //    for (int i = 0; i < cols; i++)
        //    {
        //        string col = String.Empty;
        //        for (int j = 0; j < rows; j++)
        //        {
        //            if (grid[j, i] != '\0')
        //                col += grid[j, i];
        //        }
        //        line += col + " ";
        //    }
        //    Console.WriteLine(line.Trim());
        //}
        #endregion
        #region Other Solutions2
        //static void Main(String[] args)
        //{
        //    string s = Console.ReadLine();
        //    int length = s.Length;
        //    int col = (int)Math.Ceiling(Math.Sqrt(s.Length));
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < col; i++)
        //    {
        //        int j = i;
        //        do
        //        {
        //            sb.Append(s[j]);
        //            j += col;
        //        } while (j < length);
        //        sb.Append(' ');
        //    }
        //    Console.WriteLine(sb.ToString());
        //}
        #endregion
    }
}
