using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
         
            for (int i = 0; i < T; i++)
            {
                string S = Console.ReadLine();
                var even = new StringBuilder();
                var odd = new StringBuilder();
                for (int j = 0; j < S.Length; j++)
                {
                    if (j % 2 == 0)
                        even.Append(S[j]);
                    else
                        odd.Append(S[j]);
                }
                Console.WriteLine(even + " " + odd);
            }
        }
        #region Solution1
    //    int numberOfTastCase = Convert.ToInt32(Console.ReadLine());
        
    //    for(int i=0;i<numberOfTastCase;i++){ 
    //        char[] stringCol = Console.ReadLine().ToCharArray();

    //    string firstString = string.Empty;
    //    string lastString = string.Empty;
            
    //        for(int j=0;j<stringCol.Length;j++)
    //        {
    //            firstString+= (j%2)==0 ? stringCol[j].ToString() : "";
    //            lastString+= (j%2)!=0 ? stringCol[j].ToString() : "";
    //        }

    //Console.WriteLine(firstString+" "+lastString);            
    //    }
        #endregion
    }
}
