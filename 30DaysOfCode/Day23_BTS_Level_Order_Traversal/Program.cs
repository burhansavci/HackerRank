using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_BTS_Level_Order_Traversal
{
    class Program
    {
        class Node
        {
            public Node(int data)
            {
                this.data = data;
            }
            public Node right { get; set; }
            public Node left { get; set; }
            public int data { get; set; }
        }
        static void levelOrder(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            if (root != null)
            {
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    root = queue.Dequeue();
                    if (root.left != null)
                        queue.Enqueue(root.left);
                    Console.Write(root.data + " ");
                    if (root.right != null)
                        queue.Enqueue(root.right);
                }

            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
            Console.ReadKey();
        }
        #region Solution2
        //static void levelOrder(Node root)
        //{
        //    //Write your code here
        //    List<Node> l = new List<Node>();
        //    List<string> ls = new List<string>();
        //    l.Add(root);

        //    while (l.Count > 0)
        //    {
        //        if (l[0].left != null)
        //        {
        //            l.Add(l[0].left);
        //        }
        //        if (l[0].right != null)
        //        {
        //            l.Add(l[0].right);
        //        }
        //        ls.Add((l[0].data).ToString());
        //        l.RemoveAt(0);
        //    }

        //    Console.WriteLine(string.Join(" ", ls.ToArray()));

        //}

        #endregion
    }
}

