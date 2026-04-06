using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_6
{
    public class BooksCollections
    {
        public string BookName;
        public string AuthorName;

        public BooksCollections(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }
        public void Display()
        {
            Console.WriteLine($" Book Name: {BookName}\n Author Name: {AuthorName}");
        }
    }
    public class  BooksCount
    {
        BooksCollections[] book=new BooksCollections[5];
        public BooksCollections this[int index]
        {
            get { return book[index]; }
            set { book[index] = value; }

        }

    }
    internal class ArrayofBooks
    {
        public static void Main()
        {
            BooksCount b = new BooksCount();

            b[0] = new BooksCollections("C# Basics ", "John");
            b[1] = new BooksCollections("C Basics ", "Max");
            b[2] = new BooksCollections("Python ", "Steve");
            b[3] = new BooksCollections("DSA ", "Alice");
            b[4] = new BooksCollections("OOP-Concepts", "Will");

            for (int i = 0; i < 5; i++)
            {
                b[i].Display();
                Console.WriteLine(" ");
            }

        }
    }
        
}
