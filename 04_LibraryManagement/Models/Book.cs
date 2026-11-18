using System;
using System.Collections.Generic;
using System.Text;

namespace _04_LibraryManagement.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int _pageCount;

        public int PageCount
        {
            get
            {
                return _pageCount;
            }
            private set
            {
                if (value < 1)
                {
                    throw new Exception("PageCount 1 den kicik ola bilmez!");
                }
                _pageCount = value;
            }
        }




        public Book(string name,string author,int pagecount)
        {
            Name = name;
            Author = author;
            PageCount = pagecount;
        }
    }

}
