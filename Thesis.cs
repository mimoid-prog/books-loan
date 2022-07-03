using System;
namespace zaliczenie
{
    public class Thesis : Item
    {
        public string title;
        public string author;

        public Thesis(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
    }
}

