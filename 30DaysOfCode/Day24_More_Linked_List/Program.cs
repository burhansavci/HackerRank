using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_More_Linked_List
{
    class Program
    {
        public class Node
        {
            public Node(int data)
            {
                this.data = data;
            }
            public Node next { get; set; }
            public int data { get; set; }
        }
        public static Node removeDuplicates(Node head)
        {
            if (head.next == null )
                return head;
            if (head.data == head.next.data)
            {
                head.next = head.next.next;
                return removeDuplicates(head);
            }
            else
                removeDuplicates(head.next);
            return head;
        }
        #region Solution1
        //public static Node removeDuplicates(Node head)
        //{
        //    Node current = head;
        //    Node next;

        //    while (current != null)
        //    {
        //        next = current.next;

        //        if (next == null || current.data != next.data)
        //        {
        //            current = next;
        //        }
        //        else
        //        {
        //            current.next = next.next;
        //            next.next = null;
        //        }
        //    }

        //    return head;
        //}
        #endregion

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
            Console.ReadKey();
        }
    }
}

