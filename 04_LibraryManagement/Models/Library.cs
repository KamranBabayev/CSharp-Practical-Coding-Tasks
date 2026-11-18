using System;
using System.Collections.Generic;
using System.Text;

namespace _04_LibraryManagement.Models
{
    internal class Library
    {
        public List<Book> books=new List<Book>();
        public void AddBook(Book newBook)
        {
            foreach (var book in books)
            {
                if (book.Name == newBook.Name)
                {
                    return;
                }
            }

            books.Add(newBook);
        }



        public void FindBookByAuthor(string author)
        {
            foreach(var book in books)
            {
                if (book.Author == author)
                {
                    Console.WriteLine($"BookName:{book.Name}");
                    Console.WriteLine($"BookAuthor:{book.Author}");
                }
            }
        }

    }
}
