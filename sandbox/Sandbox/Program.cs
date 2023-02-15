using System;
using System.Collections.Generic;

// Shopping Cart Program (With Classes)

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("A great book");
        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Andrew");
        book2.SetTitle("Epic Book yo");
        book2.SetIllustrator("John");

        Console.WriteLine(book2.GetPictureBookInfo());
    }
}