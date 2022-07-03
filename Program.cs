using UtilityMethods;

//Praca zaliczeniowa wykonana przez Mateusz Szkop (18341) i Marcin Brodowski (18898)
//Wysłaliśmy obaj na Moodle dla pewności

namespace zaliczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookStore bookStore = new BookStore();
            MagazineStore magazineStore = new MagazineStore();
            FilmStore filmStore = new FilmStore();
            ThesisStore thesisStore = new ThesisStore();
            LoanStore loanStore = new LoanStore();

            var state = LoadState();
            if (state != null)
            {
                bookStore.books = state.books;
                magazineStore.magazines = state.magazines;
                filmStore.films = state.films;
                thesisStore.theses = state.theses;
                loanStore.loans = state.loans;
            }

            Boolean isAppRunning = true;

            Console.WriteLine("Witam Cie w bibliotece!");
            Console.WriteLine();

            Console.WriteLine("-----TWORZENIE-----");
            Console.WriteLine("1. Dodanie ksiazki");
            Console.WriteLine("2. Dodanie czasopisma");
            Console.WriteLine("3. Dodanie filmu");
            Console.WriteLine("4. Dodanie pracy naukowej");

            Console.WriteLine("-----USUWANIE-----");
            Console.WriteLine("5. Usuniecie ksiazki");
            Console.WriteLine("6. Usuniecie czasopisma");
            Console.WriteLine("7. Usuniecie filmu");
            Console.WriteLine("8. Usuniecie pracy naukowej");

            Console.WriteLine("-----WYSWIETLANIE-----");
            Console.WriteLine("9. Wyswietl wszystkie ksiazki");
            Console.WriteLine("10. Wyswietl wszystkie czasopisma");
            Console.WriteLine("11. Wyswietl wszystkie filmy");
            Console.WriteLine("12. Wyswietl wszystkie prace naukowe");
            Console.WriteLine("13. Wyswietl wypozyczenia");

            Console.WriteLine("-----WYPOZYCZANIE-----");
            Console.WriteLine("14. Wypozycz przedmiot");
            Console.WriteLine("15. Zwroc przedmiot");

            Console.WriteLine("-----INNE-----");
            Console.WriteLine("16. Opusc biblioteke");

            while (isAppRunning)
            {
                Console.WriteLine();
                string userChoice = Utilities.CreateSafeInteraction("Co chcesz zrobic? (wybierz numer 1-16)");

                switch (userChoice)
                {
                    case "1":
                        {
                            bookStore.CreateBook();
                            break;
                        }
                    case "2":
                        {
                            magazineStore.CreateMagazine();
                            break;
                        }
                    case "3":
                        {
                            filmStore.CreateFilm();
                            break;
                        }
                    case "4":
                        {
                            thesisStore.CreateThesis();
                            break;
                        }
                    case "5":
                        {
                            bookStore.DeleteBook();
                            break;
                        }
                    case "6":
                        {
                            magazineStore.DeleteMagazine();
                            break;
                        }
                    case "7":
                        {
                            filmStore.DeleteFilm();
                            break;
                        }
                    case "8":
                        {
                            thesisStore.DeleteThesis();
                            break;
                        }
                    case "9":
                        {
                            bookStore.ShowBooks();
                            break;
                        }
                    case "10":
                        {
                            magazineStore.ShowMagazines();
                            break;
                        }
                    case "11":
                        {
                            filmStore.ShowFilms();
                            break;
                        }
                    case "12":
                        {
                            thesisStore.ShowTheses();
                            break;
                        }
                    case "13":
                        {
                            loanStore.ShowLoans();
                            break;
                        }
                    case "14":
                        {
                            loanStore.CreateLoan(bookStore.books, magazineStore.magazines, filmStore.films, thesisStore.theses);
                            break;
                        }
                    case "15":
                        {
                            loanStore.DeleteLoan(bookStore.books, magazineStore.magazines, filmStore.films, thesisStore.theses);
                            break;
                        }
                    default:
                        {
                            isAppRunning = false;
                            break;
                        }
                }

                SaveState(bookStore.books, magazineStore.magazines, filmStore.films, thesisStore.theses, loanStore.loans);
            }

            return;
        }

        public static void SaveState(List<Book> books, List<Magazine> magazines, List<Film> films, List<Thesis> theses, List<Loan> loans)
        {
            State state = new State(books, magazines, films, theses, loans);
            var writer = new Writer<State>();
            writer.Write(state);
        }

        public static State? LoadState()
        {
            var reader = new Reader<State>();
            var state = reader.Read();
            return state;
        }
    }
}
