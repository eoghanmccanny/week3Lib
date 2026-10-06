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

        public void Displayinfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Isbn: {Isbn}");
        }
    }
}


