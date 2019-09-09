using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day28_RegEx__Patterns_and_Intro_to_Databases
{
    class Program
    {
        class Email
        {
            public string FirstName { get; set; }
            public string EMailID { get; set; }
        }
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var Emails = new List<Email>();
            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                Emails.Add(new Email
                {
                    FirstName = firstNameEmailID[0],
                    EMailID = firstNameEmailID[1]
                });
            }
            Emails.RemoveAll(p => p.EMailID.Split('@')[1].ToString() != "gmail.com");

            foreach (var item in Emails.OrderBy(p => p.FirstName))
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }

        #region Solution1
        //static void Main(String[] args)
        //{
        //    List<string> names = new List<string>();
        //    Regex re = new Regex(@"@gmail.com$");

        //    int N = Convert.ToInt32(Console.ReadLine());
        //    for (int a0 = 0; a0 < N; a0++)
        //    {
        //        string[] tokens_firstName = Console.ReadLine().Split(' ');
        //        string firstName = tokens_firstName[0];
        //        string emailID = tokens_firstName[1];
        //        if (re.IsMatch(emailID))
        //        {
        //            names.Add(firstName);
        //        }
        //    }

        //    foreach (string name in names.OrderBy(n => n))
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        #endregion
        #region Solution2
        //static void Main(String[] args)
        //{
        //    int N = Convert.ToInt32(Console.ReadLine());
        //    List<string> gmailUsers = new List<string>();
        //    string pattern = @"\b\w+@gmail\.com\b";
        //    Regex rgx = new Regex(pattern);

        //    for (int a0 = 0; a0 < N; a0++)
        //    {
        //        string[] tokens_firstName = Console.ReadLine().Split(' ');
        //        string firstName = tokens_firstName[0];
        //        string emailID = tokens_firstName[1];
        //        if (rgx.IsMatch(emailID)) gmailUsers.Add(firstName);
        //    }
        //    gmailUsers.Sort();
        //    Console.WriteLine(String.Join(Environment.NewLine, gmailUsers));
        //}
        #endregion
    }
}
