using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    public class Book
    {
        public string Title;
        public string Author;
        public int Isbn;

        // paramaterized constructor
        public Book(string bookTitle, string bookAuthor, int bookIsbn)
        {
            Title = bookTitle;
            Author = bookAuthor;
            Isbn = bookIsbn;
        }

        public void Displayinfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Isbn: {Isbn}");
        }
    }


}


