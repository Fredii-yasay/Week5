using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Book
    {
        public string Title;
        public string Author;

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book Information:\n" +
                $"Title: {this.Title}\n" +
                $"Author: {this.Author}");
        }
    }
}
