using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_6
{
    internal class Books
    {
        public class BooksCollection
        {
            public string BookName;
            public string AuthorName;

            public BooksCollection(string bookName, string authorName)
            {
                BookName = bookName;
                AuthorName = authorName;
            }
            public void Display()
            {
                Console.WriteLine($" BookName: {BookName}\n AuthorName: {AuthorName}");
            }
        }
        public class BooksCount
        {
            public BooksCollection[] books = new BooksCollection[5];
            public BooksCollection this[int index]
            {
                get { return books[index]; }
                set { books[index] = value; }
            }

        }
        internal class Books
        {
            public static void Main()
            {
                BooksCount b = new BooksCount();

                b[0] = new BooksCollection("C# Basics ", "John");
                b[1] = new BooksCollection("C Basics ", "Max");
                b[2] = new BooksCollection("Python ", "Steve");
                b[3] = new BooksCollection("DSA ", "Alice");
                b[4] = new BooksCollection("OOP-Concepts", "Will");

                for (int i = 0; i < 5; i++)
                {
                    b[i].Display();
                    Console.WriteLine(" ");
                }

            }
        }
    }
}
