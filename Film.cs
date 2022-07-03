using System;
namespace zaliczenie
{
    public class Film : Item
    {
        public string title;
        public string director;

        public Film(string title, string director)
        {
            this.title = title;
            this.director = director;
        }
    }
}

