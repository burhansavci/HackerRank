using System;
using System.Collections.Generic;

namespace Day18_QueuesAndStacks
{
    class Program
    {
        class Solution
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>(); 
            void pushCharacter(char ch)
            {
                stack.Push(ch.ToString());
            }
            char popCharacter()
            {
                return stack.Pop().ToCharArray()[0];
            }
            void enqueueCharacter(char ch)
            {
                queue.Enqueue(ch.ToString());
            }
            char dequeueCharacter()
            {
                return queue.Dequeue().ToCharArray()[0];
            }
            static void Main(String[] args)
            {
                // read the string s.
                string s = Console.ReadLine();

                // create the Solution class object p.
                Solution obj = new Solution();

                // push/enqueue all the characters of string s to stack.
                foreach (char c in s)
                {
                    obj.pushCharacter(c);
                    obj.enqueueCharacter(c);
                }

                bool isPalindrome = true;

                // pop the top character from stack.
                // dequeue the first character from queue.
                // compare both the characters.
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (obj.popCharacter() != obj.dequeueCharacter())
                    {
                        isPalindrome = false;

                        break;
                    }
                }

                // finally print whether string s is palindrome or not.
                if (isPalindrome)
                {
                    Console.Write("The word, {0}, is a palindrome.", s);
                }
                else
                {
                    Console.Write("The word, {0}, is not a palindrome.", s);
                }
                Console.ReadKey();
            }

            #region Solution1
            //class Solution
            //{
            //    //Write your code here

            //    List<char> stacker = new List<char>();
            //    List<char> queuer = new List<char>();

            //    public void pushCharacter(char ch)
            //    {
            //        stacker.Add(ch);
            //    }

            //    public void enqueueCharacter(char ch)
            //    {
            //        queuer.Add(ch);
            //    }

            //    public char popCharacter()
            //    {
            //        char retVal = stacker[stacker.Count - 1];
            //        stacker.RemoveAt(stacker.Count - 1);
            //        return retVal;
            //    }

            //    public char dequeueCharacter()
            //    {
            //        char retVal = queuer[0];
            //        queuer.RemoveAt(0);
            //        return retVal;
            //    }

                #endregion
            }
        }
}
