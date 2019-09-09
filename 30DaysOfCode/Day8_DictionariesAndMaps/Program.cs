using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var phoneBook = new Dictionary<string, string>();
            var names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var pair = Console.ReadLine().Split(' ');
                phoneBook.Add(pair[0], pair[1]);
            }
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                names.Add(input);
                input = Console.ReadLine();
            }
            foreach (var name in names)
            {
                if (!phoneBook.ContainsKey(name))
                    Console.WriteLine("Not found");
                else
                    Console.WriteLine($"{name}={phoneBook[name]}");
            }
        }
        #region Solution1
        //static void Main(String[] args)
        //{
        //    Dictionary<String, String> phoneBook = new Dictionary<String, String>();

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < n; i++)
        //    {
        //        String name_temp = Console.ReadLine();
        //        String phone_temp = Console.ReadLine();

        //        phoneBook.Add(name_temp, phone_temp);
        //    }

        //    String query;

        //    while ((query = Console.ReadLine()) != null)
        //    {
        //        if (phoneBook.ContainsKey(query))
        //        {
        //            Console.WriteLine("{0}={1}", query, phoneBook[query]);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Not found");
        //        }
        //    }
        //}
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    int n = Int32.Parse(Console.ReadLine());
        //    Dictionary<string, string> d = new Dictionary<string, string>();
        //    for (int a = 0; a < n; a++)
        //    {
        //        string name = Console.ReadLine();
        //        string numb = Console.ReadLine();
        //        d.Add(name, numb);
        //    }
        //    string query = "";
        //    while (true)
        //    {
        //        query = Console.ReadLine();
        //        if (query == null) break;
        //        try
        //        {
        //            Console.WriteLine(query + "=" + d[query]);
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Not found");
        //        }
        //    }
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //}
        #endregion
    }
}
