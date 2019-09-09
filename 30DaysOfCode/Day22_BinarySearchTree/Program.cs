using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_BinarySearchTree
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
        static int getHeight(Node root)
        {
            if (root == null)
                return -1;
            int rightHeight = getHeight(root.right);
            int leftHeight = getHeight(root.left);
            return (rightHeight > leftHeight ? rightHeight : leftHeight) + 1;
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
            int height = getHeight(root);
            Console.WriteLine(height);
            Console.ReadKey();
        }
    }
}

