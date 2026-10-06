using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lib
{
    public class Book
    {
        // private fields
        private string _Title;
        private string _Author;
        private int _Isbn;
        // public properties
        public string Title
        {
            get { return _Title; }
            set 
            {
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Title cannot contain digits.");
                }   
                _Title = value;
            }
        } // check if any incoming char is a digit
         
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }
        public int Isbn
        {
            get { return _Isbn; }
            set { _Isbn = value; }
        }

        // constructor 
        public Book(string bookTitle, string bookAuthor, int bookIsbn)
        {
            Title = bookTitle;
            Author = bookAuthor;
            Isbn = bookIsbn;
        }
        // methods
        public void Displayinfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Isbn: {Isbn}");
        }

        // paramaterized constructor


      
    }


}


