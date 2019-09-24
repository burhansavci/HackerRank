using System;

namespace DesignerPDFViewer
{
    class Program
    {
        static int designerPdfViewer(int[] h, string word)
        {
            int maxHeight = 0;
            foreach (var letter in word)
            {
                var indexOfLetter = (int)letter - 97;
                if (h[indexOfLetter] > maxHeight)
                    maxHeight = h[indexOfLetter];
            }
            return word.Length * maxHeight;
        }

        static void Main(string[] args)
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));

            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        #region OtherSolutions1
        //static void Main(String[] args)
        //{
        //    string[] h_temp = Console.ReadLine().Split(' ');
        //    int[] h = Array.ConvertAll(h_temp, Int32.Parse);
        //    string word = Console.ReadLine();

        //    Console.Out.WriteLine(word.ToCharArray().Max(ch => h[ch - 'a']) * word.Length);
        //}
        #endregion
    }
}
