using System;
namespace zaliczenie
{
    public class Magazine : Item
    {
        public string title;
        public string author;
        public int pages;

        public Magazine(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }
    }
}

