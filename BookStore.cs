using System;
using UtilityMethods;

namespace zaliczenie
{
    public class BookStore
    {
        public List<Book> books = new List<Book>();

        public void CreateBook()
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul ksiazki:");
            string author = Utilities.CreateSafeInteraction("Podaj autora ksiazki:");
            int pages = int.Parse(Utilities.CreateSafeInteraction("Podaj ilosc stron:"));

            Book book = new Book(title, author, pages);
            books.Add(book);
            Console.WriteLine("Dodano ksiazke.");
        }

        public void DeleteBook()
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul ksiazki do usuniecia:");

            Book? book = books.Find(b => b.title == title);

            if (book == null)
            {
                Console.Write("Nie ma ksiazki o takim tytule.");
            }
            else
            {
                books.Remove(book);
                Console.Write("Ksiazka zostala usunieta.");
            }
        }

        public void ShowBooks()
        {
            if (books.Count() == 0)
            {
                Console.WriteLine("Brak ksiazek w bibliotece");
            }
            else
            {
                Console.WriteLine("Lista ksiazek:");

                foreach (Book book in books)
                {
                    Console.WriteLine($"{book.title} - {book.author}");
                }
            }
        }
    }
}

