using System;
namespace zaliczenie
{
    public class Book : Item
    {
        public string title;
        public string author;
        public int pages;

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }
    }
}

