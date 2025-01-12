using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Library
    {
        public Book[] books;
        public Library(int capacity)
        {
            books = new Book[capacity];
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Enter book title: ");
                string title = Console.ReadLine();
                book.Title = title;

                Console.WriteLine("Enter book author: ");
                string author = Console.ReadLine();
                book.Author = author;
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library: ");
            for (int i = 0;i < books.Length;i++)
            {
                Console.WriteLine($"{books[i].Title} by {books[i].Author}");
            }
        }
    }
}
