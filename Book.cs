using System;
namespace zaliczenie
{
    public class Book : Item
    {
        public string title;
        public string author;
        public string pages;

        public Book(string title, string author, string pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }
    }
}

