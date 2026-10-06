using lib;

Book book = new Book();

// this is info for the book class 

book.Title = "C# in Depth";
book.Author = "Bill Gates";
book.Isbn = 12345678;
book.Displayinfo();

// add another book 
Book book1 = new Book();
book1.Title = "C# in Depth 2nd Edition";
book1.Author = "Jon Skeet";
book1.Isbn = (int)2787;
book1.Displayinfo() ;
