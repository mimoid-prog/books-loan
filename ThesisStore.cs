using System;
using UtilityMethods;

namespace zaliczenie
{
    public class ThesisStore
    {
        public List<Thesis> theses = new List<Thesis>();

        public void CreateThesis()
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul pracy naukowej:");
            string author = Utilities.CreateSafeInteraction("Podaj autora pracy naukowej:");

            Thesis thesis = new Thesis(title, author);
            theses.Add(thesis);
            Console.WriteLine("Dodano prace naukowa.");
        }

        public void DeleteThesis()
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul pracy naukowej do usuniecia:");

            Thesis? thesis = theses.Find(b => b.title == title);

            if (thesis == null)
            {
                Console.Write("Nie ma pracy naukowej o takim tytule.");
            }
            else
            {
                theses.Remove(thesis);
                Console.Write("Praca naukowa zostala usunieta.");
            }
        }

        public void ShowTheses()
        {
            if (theses.Count() == 0)
            {
                Console.WriteLine("Brak prac naukowych w bibliotece.");
            }
            else
            {
                Console.WriteLine("Lista prac naukowych:");

                foreach (Thesis thesis in theses)
                {
                    Console.WriteLine($"{thesis.title} - {thesis.author}");
                }
            }
        }
    }
}

