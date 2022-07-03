using System;
using UtilityMethods;

namespace zaliczenie
{
    public class FilmStore
    {
        public List<Film> films = new List<Film>();

        public void CreateFilm()
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul filmu:");
            string director = Utilities.CreateSafeInteraction("Podaj rezysera filmu:");

            Film film = new Film(title, director);
            films.Add(film);
            Console.WriteLine("Dodano film.");
        }

        public void DeleteFilm()
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul filmu do usuniecia:");

            Film? film = films.Find(b => b.title == title);

            if (film == null)
            {
                Console.Write("Nie ma filmu o takim tytule.");
            }
            else
            {
                films.Remove(film);
                Console.Write("Film zostal usuniety.");
            }
        }

        public void ShowFilms()
        {
            if (films.Count() == 0)
            {
                Console.WriteLine("Brak filmow w bibliotece");
            }
            else
            {
                Console.WriteLine("Lista filmow:");

                foreach (Film film in films)
                {
                    Console.WriteLine($"{film.title} - {film.director}");
                }
            }
        }
    }
}

