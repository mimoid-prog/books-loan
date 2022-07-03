using System;
using UtilityMethods;

namespace zaliczenie
{
    public class MagazineStore
    {
        public List<Magazine> magazines = new List<Magazine>();

        public void CreateMagazine()
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul czasopisma:");
            string author = Utilities.CreateSafeInteraction("Podaj autora czasopisma:");
            int pages = int.Parse(Utilities.CreateSafeInteraction("Podaj ilosc stron:"));

            Magazine magazine = new Magazine(title, author, pages);
            magazines.Add(magazine);
            Console.WriteLine("Dodano ksiazke.");
        }

        public void DeleteMagazine()
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul czasopisma do usuniecia:");

            Magazine? magazine = magazines.Find(b => b.title == title);

            if (magazine == null)
            {
                Console.Write("Nie ma czasopisma o takim tytule.");
            }
            else
            {
                magazines.Remove(magazine);
                Console.Write("Ksiazka zostala usunieta.");
            }
        }

        public void ShowMagazines()
        {
            if (magazines.Count() == 0)
            {
                Console.WriteLine("Brak czasopism w bibliotece.");
            }
            else
            {
                Console.WriteLine("Lista czasopism:");

                foreach (Magazine magazine in magazines)
                {
                    Console.WriteLine($"{magazine.title} - {magazine.author}");
                }
            }
        }
    }
}

