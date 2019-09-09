using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_AbstractClasses
{
    class Program
    {
        abstract class Book
        {
            protected string title;
            protected string author;
            public Book(string title, string author)
            {
                this.title = title;
                this.author = author;
            }

        public virtual void display() { }
        }
        class MyBook : Book
        {
            private int price;
            public MyBook(string title, string author, int price) : base(title, author)
            {
                this.price = price;
            }
            public override void display()
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Price: " + price);
            }
        }

        class Solution
        {
            static void Main(String[] args)
            {
                String title = Console.ReadLine();
                String author = Console.ReadLine();
                int price = Int32.Parse(Console.ReadLine());
                Book new_novel = new MyBook(title, author, price);
                new_novel.display();
            }
        }
    }
}
