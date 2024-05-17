namespace Book_Library
{
    internal class Program //Definira internu (vidljivu unutar iste skupine) klasu naziva Program.
    {
        // Stvaranje static liste koja će sadržavati objekte tipa Book.
        static List<Book> bookList = new List<Book>();

        // Glavna metoda programa.
        static void Main(string[] args)
        {
            // Inicijalizacija varijable choseMenu na 0.
            int choseMenu = 0;

            // Kreiranje instance autora i knjige, te dodavanje knjige u listu.
            var author = new Author("\nDr Steve ", "Peters", 100);
            var book = new Book("The Chimp Paradox ", author, 100);
            bookList.Add(book);

            // Petlja koja se izvršava dok choseMenu nije veći od 3.
            while (choseMenu < 3)
            {
                try
                {
                    // Pozivanje metode BookLibrary za ispis menija.

                    BookLibrary();

                    // Čitanje korisničkog unosa i pretvaranje u integer.
                    choseMenu = Convert.ToInt32(Console.ReadLine());

                    // Switch blok koji obrađuje odabrane opcije.
                    switch (choseMenu)
                    {
                        case 1:
                            // Ispis svih knjiga u biblioteci.
                            Console.WriteLine("LIST ALL BOOKS! ");
                            Console.WriteLine("------------------------------");

                            // Iteracija kroz sve knjige u listi.
                            foreach (var book1 in bookList)
                            {
                                Console.WriteLine("------------------------------");
                                Console.WriteLine(book1.Author.FirstName);
                                Console.WriteLine(book1.Author.LastName);
                                Console.WriteLine(book1.Title);
                                Console.WriteLine($"Random Number: " + book.Id);
                                Console.WriteLine("------------------------------");
                            }
                            break;

                        case 2:
                            // Dodavanje nove knjige u biblioteku.
                            Console.WriteLine("ADD NEW BOOK TO LIBRARY! ");
                            Console.WriteLine("------------------------------");
                            Console.WriteLine($"Random Number: " + author.Id);
                            AddNewBook();
                            break;

                        default:
                            // Ispis poruke o izlasku iz programa.
                            Console.WriteLine(" EXIT PROGRAM! ");
                            Console.WriteLine("------------------------------");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    // Prikaz poruke o grešci ako dođe do izuzetka.
                    Console.WriteLine($"An error has occurred: {ex.Message}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
            // Inkrementiranje choseMenu izvan petlje.
            choseMenu++;
        }

        // Metoda za ispis menija.
        static void BookLibrary()
        {
            Console.WriteLine("        Book library          ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("CHOOSE YOUR OPTION FROM MENU: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("PRESS 1: LIST ALL BOOKS. ");
            Console.WriteLine("PRESS 2: ADD NEW BOOK TO LIBRARY. ");
            Console.WriteLine("PRESS 3: EXIT PROGRAM. ");
            Console.WriteLine("------------------------------");
        }

        // Metoda za dodavanje nove knjige.
        static void AddNewBook()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Author Second Name: ");
            string lastName = Console.ReadLine();

            // Kreiranje nove instance autora i knjige, te dodavanje knjige u listu.
            var newAuthor = new Author(firstName, lastName, 150);
            var newBook = new Book(title, newAuthor, 12);
            bookList.Add(newBook);
        }
    }

    // Definicija klase Author.
    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        // Konstruktor klase Author.
        public Author(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.LastName = lastName;

            // Generisanje random ID-a za autora.
            Random random = new Random();
            this.Id = random.Next();
        }
    }

    // Definicija klase Book.
    class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int Id { get; set; }

        // Konstruktor klase Book.
        public Book(string title, Author author, int id)
        {
            this.Title = title;
            this.Author = author;
            this.Title = Title;
            this.Author = author;

            // Generisanje random ID-a za knjigu.
            Random random = new Random();
            this.Id = random.Next();
        }
    }
}
