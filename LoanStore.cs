using System;
using UtilityMethods;

namespace zaliczenie
{
    public class LoanStore
    {
        public List<Loan> loans = new List<Loan>();

        public void CreateLoan(List<Book> books, List<Magazine> magazines, List<Film> films, List<Thesis> theses)
        {
            Console.WriteLine();
            Console.WriteLine("Lista przedmiotow do wypozyczenia:");
            Console.WriteLine("1. Ksiazka");
            Console.WriteLine("2. Czasopismo");
            Console.WriteLine("3. Film");
            Console.WriteLine("4. Praca naukowa");

            string userChoice = Utilities.CreateSafeInteraction("Co chcesz wypozyczyc? (wybierz numer 1-4)");

            switch (userChoice)
            {
                case "1":
                    {
                        CreateBookLoan(books);
                        break;
                    }
                case "2":
                    {
                        CreateMagazineLoan(magazines);
                        break;
                    }
                case "3":
                    {
                        CreateFilmLoan(films);
                        break;
                    }
                case "4":
                    {
                        CreateThesisLoan(theses);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiej opcji.");
                        break;
                    }
            }
        }

        private void FinalizeLoan(List<Loan> loans, string itemId)
        {
            string loanerName = Utilities.CreateSafeInteraction("Podaj imie i nazwisko wypozyczajacego:");
            Loan loan = new Loan(itemId, loanerName);
            loans.Add(loan);
        }


        private void CreateBookLoan(List<Book> books)
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul ksiazki:");
            Book? book = books.Find(book => book.title == title);

            if (book == null)
            {
                Console.WriteLine("Nie ma ksiazki o tej nazwie.");
                return;
            }

            Loan? existingLoan = loans.Find(l => l.itemId == book.id);

            if (existingLoan != null)
            {
                Console.WriteLine("Ta ksiazka jest juz wypozyczona. Sprobuj kiedy indziej.");
                return;
            }

            FinalizeLoan(loans, book.id);
            Console.WriteLine("Wypozyczono ksiazke.");
        }

        private void CreateMagazineLoan(List<Magazine> magazines)
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul czasopisma:");
            Magazine? magazine = magazines.Find(magazine => magazine.title == title);

            if (magazine == null)
            {
                Console.WriteLine("Nie ma czasopisma o tej nazwie.");
                return;
            }

            Loan? existingLoan = loans.Find(l => l.itemId == magazine.id);

            if (existingLoan != null)
            {
                Console.WriteLine("To czasopismo jest juz wypozyczone. Sprobuj kiedy indziej.");
                return;
            }

            FinalizeLoan(loans, magazine.id);
            Console.WriteLine("Wypozyczono czasopismo.");
        }

        private void CreateFilmLoan(List<Film> films)
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul filmu:");
            Film? film = films.Find(film => film.title == title);

            if (film == null)
            {
                Console.WriteLine("Nie ma filmu o tej nazwie.");
                return;
            }

            Loan? existingLoan = loans.Find(l => l.itemId == film.id);

            if (existingLoan != null)
            {
                Console.WriteLine("Ten film jest juz wypozyczony. Sprobuj kiedy indziej.");
                return;
            }

            FinalizeLoan(loans, film.id);
            Console.WriteLine("Wypozyczono film.");
        }

        private void CreateThesisLoan(List<Thesis> theses)
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul pracy naukowej:");
            Thesis? thesis = theses.Find(thesis => thesis.title == title);

            if (thesis == null)
            {
                Console.WriteLine("Nie ma pracy naukowej o tej nazwie.");
                return;
            }

            Loan? existingLoan = loans.Find(l => l.itemId == thesis.id);

            if (existingLoan != null)
            {
                Console.WriteLine("Ta praca naukowa jest juz wypozyczona. Sprobuj kiedy indziej.");
                return;
            }

            FinalizeLoan(loans, thesis.id);
            Console.WriteLine("Wypozyczono prace naukowa.");
        }

        public void DeleteLoan(List<Book> books, List<Magazine> magazines, List<Film> films, List<Thesis> theses)
        {
            Console.WriteLine("Co chcesz zwrocic? (wybierz numer 1-4)");
            Console.WriteLine("1. Ksiazka");
            Console.WriteLine("2. Czasopismo");
            Console.WriteLine("3. Film");
            Console.WriteLine("4. Praca naukowa");

            string userChoice = Utilities.CreateSafeInteraction("Co chcesz zwrocic? (wybierz numer 1-4)");

            switch (userChoice)
            {
                case "1":
                    {
                        DeleteBookLoan(books);
                        break;
                    }
                case "2":
                    {
                        DeleteMagazineLoan(magazines);
                        break;
                    }
                case "3":
                    {
                        DeleteFilmLoan(films);
                        break;
                    }
                case "4":
                    {
                        DeleteThesisLoan(theses);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiej opcji.");
                        break;
                    }
            }
        }

        private void DeleteBookLoan(List<Book> books)
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul ksiazki:");
            Book? book = books.Find(book => book.title == title);

            if (book == null)
            {
                Console.WriteLine("Nie ma ksiazki o tej nazwie.");
                return;
            }

            Loan? existingLoan = loans.Find(l => l.itemId == book.id);

            if (existingLoan == null)
            {
                Console.WriteLine("Ta ksiazka nie jest wypozyczona! Zastanow sie co chcesz zwrocic.");
                return;
            }

            loans.Remove(existingLoan);
            Console.WriteLine("Zwrocono ksiazke.");
        }

        private void DeleteMagazineLoan(List<Magazine> magazines)
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul czasopisma:");
            Magazine? magazine = magazines.Find(magazine => magazine.title == title);

            if (magazine == null)
            {
                Console.WriteLine("Nie ma czasopisma o tej nazwie.");
                return;
            }

            Loan? existingLoan = loans.Find(l => l.itemId == magazine.id);

            if (existingLoan == null)
            {
                Console.WriteLine("To czasopismo nie jest wypozyczone! Zastanow sie co chcesz zwrocic.");
                return;
            }

            loans.Remove(existingLoan);
            Console.WriteLine("Zwrocono czasopismo.");
        }

        private void DeleteFilmLoan(List<Film> films)
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul filmu:");
            Film? film = films.Find(film => film.title == title);

            if (film == null)
            {
                Console.WriteLine("Nie ma filmu o tej nazwie.");
                return;
            }

            Loan? existingLoan = loans.Find(l => l.itemId == film.id);

            if (existingLoan == null)
            {
                Console.WriteLine("Ten film nie jest wypozyczony! Zastanow sie co chcesz zwrocic.");
                return;
            }

            loans.Remove(existingLoan);
            Console.WriteLine("Zwrocono film.");
        }

        private void DeleteThesisLoan(List<Thesis> theses)
        {
            string title = Utilities.CreateSafeInteraction("Podaj tytul pracy naukowej:");
            Thesis? thesis = theses.Find(thesis => thesis.title == title);

            if (thesis == null)
            {
                Console.WriteLine("Nie ma pracy naukowej o tej nazwie.");
                return;
            }

            Loan? existingLoan = loans.Find(l => l.itemId == thesis.id);

            if (existingLoan == null)
            {
                Console.WriteLine("Ta praca naukowa nie jest wypozyczona! Zastanow sie co chcesz zwrocic.");
                return;
            }

            loans.Remove(existingLoan);
            Console.WriteLine("Zwrocono prace naukowa.");
        }

        public void ShowLoans()
        {
            if (loans.Count() == 0)
            {
                Console.WriteLine("Brak wypozyczen w bibliotece");
            }
            else
            {
                Console.WriteLine("Lista wypozyczen:");

                foreach (Loan loan in loans)
                {
                    Console.WriteLine($"{loan.loanerName} wypozyczyl przedmiot o id {loan.itemId}");
                }
            }
        }
    }
}

