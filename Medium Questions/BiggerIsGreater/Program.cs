using System;

namespace BiggerIsGreater
{
    class Program
    {
        static string biggerIsGreater(string w)
        {
            var charArr = w.ToCharArray();
            int i = charArr.Length - 1;
            int j = charArr.Length - 1;
            while (i > 0 && charArr[i - 1] >= charArr[i]) i--;

            if (i <= 0) return "no answer";

            while (charArr[j] <= charArr[i - 1]) j--;

            char temp = charArr[i - 1];
            charArr[i - 1] = charArr[j];
            charArr[j] = temp;

            j = charArr.Length - 1;
            while (i < j)
            {
                temp = charArr[i];
                charArr[i] = charArr[j];
                charArr[j] = temp;
                i++;
                j--;
            }

            return new string(charArr);
        }

        static void Main(string[] args)
        {

            int T = Convert.ToInt32(Console.ReadLine());

            for (int TItr = 0; TItr < T; TItr++)
            {
                string w = Console.ReadLine();

                string result = biggerIsGreater(w);

                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
