using System;
namespace zaliczenie
{
    public class Magazine : Item
    {
        public string title;
        public string author;
        public string pages;

        public Magazine(string title, string author, string pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }
    }
}

